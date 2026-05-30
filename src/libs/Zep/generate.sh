#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec index: https://help.getzep.com/openapi.json
# Zep Cloud Threads API (v2) - the modern API with threads, graph, context templates

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

OPENAPI_INDEX_URL="https://help.getzep.com/openapi.json"
KNOWN_THREADS_API_ID="8935e41a-294c-41da-ba8e-d6d73cab6182"
tmp_spec="$(mktemp)"
tmp_index="$(mktemp)"
trap 'rm -f "$tmp_spec" "$tmp_index"' EXIT

download_url() {
  local destination="$1"
  local url="$2"
  local attempts="${3:-3}"
  local attempt

  for ((attempt = 1; attempt <= attempts; attempt++)); do
    if curl --fail --silent --show-error -L -o "$destination" "$url"; then
      return 0
    fi

    if (( attempt < attempts )); then
      sleep "$attempt"
    fi
  done

  return 1
}

is_threads_api_spec() {
  python3 - <<'PY' "$1"
import json
import sys

REQUIRED_PATHS = {
    "/context-templates",
    "/graph/search",
    "/threads",
    "/users",
}

with open(sys.argv[1], encoding="utf-8") as f:
    spec = json.load(f)

raise SystemExit(0 if REQUIRED_PATHS.issubset(spec.get("paths", {})) else 1)
PY
}

download_candidate_spec() {
  local api_id="$1"
  local attempts="${2:-2}"

  download_candidate_spec_url "${OPENAPI_INDEX_URL}?api=${api_id}" "$attempts"
}

download_candidate_spec_url() {
  local spec_url="$1"
  local attempts="${2:-2}"

  download_url \
    "$tmp_spec" \
    "$spec_url" \
    "$attempts" || return 1

  is_threads_api_spec "$tmp_spec"
}

selected_spec_source=""
if download_candidate_spec "$KNOWN_THREADS_API_ID" 3; then
  selected_spec_source="api=$KNOWN_THREADS_API_ID"
else
  download_url "$tmp_index" "$OPENAPI_INDEX_URL" 3

  while IFS= read -r api_id; do
    if download_candidate_spec "$api_id" 2; then
      selected_spec_source="api=$api_id"
      break
    fi
  done < <(
    python3 - "$tmp_index" <<'PY'
import re
import sys

with open(sys.argv[1], encoding="utf-8") as f:
    html = f.read()

seen = set()
for api_id in re.findall(r"[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}", html):
    if api_id in seen:
        continue
    seen.add(api_id)
    print(api_id)
PY
  )

  if [[ -z "$selected_spec_source" ]]; then
    while IFS= read -r spec_url; do
      if download_candidate_spec_url "$spec_url" 2; then
        selected_spec_source="$spec_url"
        break
      fi
    done < <(
      python3 -c '
import re
import sys
from urllib.parse import urljoin

with open(sys.argv[1], encoding="utf-8") as f:
    html = f.read()

seen = set()
for href in re.findall(r"href=\"([^\"]*openapi/[^\"]+\.json)\"", html):
    spec_url = urljoin(sys.argv[2], href)
    if spec_url in seen:
        continue
    seen.add(spec_url)
    print(spec_url)
' "$tmp_index" "$OPENAPI_INDEX_URL"
    )
  fi
fi

if [[ -z "$selected_spec_source" ]]; then
  echo "Could not resolve the Zep Threads API spec from $OPENAPI_INDEX_URL" >&2
  exit 1
fi

mv "$tmp_spec" openapi.json
tmp_spec="$(mktemp)"
echo "Downloaded Zep Threads API spec using $selected_spec_source"

# Fix dotted schema names (apidata.Foo -> ApidataFoo, graphiti.Foo -> GraphitiFoo, models.Foo -> ModelsFoo)
# Also inject securitySchemes (Bearer token) and top-level security array
python3 - <<'PY'
import json, re, sys

with open('openapi.json') as f:
    spec = json.load(f)

raw = json.dumps(spec)

# Replace dotted schema refs and names with PascalCase prefix
# e.g. apidata.AddDataRequest -> ApidataAddDataRequest
for prefix in ['apidata', 'graphiti', 'models']:
    pascal = prefix[0].upper() + prefix[1:]
    # Replace schema references
    raw = raw.replace(f'\"#/components/schemas/{prefix}.', f'\"#/components/schemas/{pascal}')
    # Replace schema key names in components/schemas
    raw = raw.replace(f'\"{prefix}.', f'\"{pascal}')

spec = json.loads(raw)

# Inject securitySchemes
if 'components' not in spec:
    spec['components'] = {}
spec['components']['securitySchemes'] = {
    'BearerAuth': {
        'type': 'http',
        'scheme': 'bearer'
    }
}

# Add top-level security
spec['security'] = [{'BearerAuth': []}]

with open('openapi.json', 'w') as f:
    json.dump(spec, f, indent=2)

print('Spec fixed: dotted names renamed, bearer auth injected')
PY

autosdk generate openapi.json \
  --namespace Zep \
  --clientClassName ZepClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
