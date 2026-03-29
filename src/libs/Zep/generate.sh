#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://help.getzep.com/openapi.json?api=a22eebbe-debf-4028-afaa-28d8a3b0b03b
# Zep Cloud Threads API (v2) — the modern API with threads, graph, context templates

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L \
  -o openapi.json \
  "https://help.getzep.com/openapi.json?api=a22eebbe-debf-4028-afaa-28d8a3b0b03b"

# Fix dotted schema names (apidata.Foo → ApidataFoo, graphiti.Foo → GraphitiFoo, models.Foo → ModelsFoo)
# Also inject securitySchemes (Bearer token) and top-level security array
python3 -c "
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
"

autosdk generate openapi.json \
  --namespace Zep \
  --clientClassName ZepClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
