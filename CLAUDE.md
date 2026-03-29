# CLAUDE.md -- Zep SDK

## Overview

Auto-generated C# SDK for [Zep](https://www.getzep.com/) -- AI agent memory and context engineering platform with temporal knowledge graphs.
OpenAPI spec from the official Zep documentation at `https://help.getzep.com/openapi.json?api=a22eebbe-debf-4028-afaa-28d8a3b0b03b` (Threads API v2).

## Build & Test

```bash
dotnet build Zep.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth with `Api-Key` scheme (keys prefixed with `z_`):

```csharp
var client = new ZepClient(apiKey); // ZEP_API_KEY env var
```

The `Authorized` hook rewrites the default Bearer header to `Authorization: Api-Key {key}`.

## Key Files

- `src/libs/Zep/openapi.json` -- OpenAPI spec (downloaded from help.getzep.com)
- `src/libs/Zep/generate.sh` -- Downloads spec, fixes dotted schema names, injects auth, runs autosdk
- `src/libs/Zep/Generated/` -- **Never edit** -- auto-generated code (~386 files)
- `src/libs/Zep/Extensions/ZepClient.PrepareRequest.cs` -- Auth hook (Bearer -> Api-Key)
- `src/libs/Zep/Extensions/ZepClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

**Two APIs available:**
- `a22eebbe-debf-4028-afaa-28d8a3b0b03b` -- Threads API (modern, used by this SDK)
- `ea907079-6c75-475f-b2fc-9f375fbaa6d2` -- Sessions API (legacy v2)

**Schema name fix:** Spec uses dotted schema names (`apidata.Foo`, `graphiti.Foo`, `models.Foo`) which are renamed to PascalCase (`ApidataFoo`, `GraphitiFoo`, `ModelsFoo`) in `generate.sh`.

**Auth fix:** Spec has no security schemes -- `generate.sh` injects `http/bearer` security; `Authorized` hook converts to `Api-Key` header at runtime.

## Sub-client Pattern

```csharp
var client = new ZepClient(apiKey);

// Thread management
client.SubpackageThread.StartANewThreadAsync(...)      // Create thread
client.SubpackageThread.GetThreadsAsync(...)            // List threads
client.SubpackageThread.AddMessagesToAThreadAsync(...)  // Add messages
client.SubpackageThread.GetUserContextAsync(...)        // Get context

// User management
client.SubpackageUser.AddAsync(...)                     // Create user
client.SubpackageUser.GetAsync(...)                     // Get user
client.SubpackageUser.GetUserNodeAsync(...)             // Get user's graph node

// Data & Graph
client.SubpackageData.AddDataAsync(...)                 // Add data to graph
client.SubpackageSearch.GraphAsync(...)                 // Search knowledge graph
client.SubpackageGraph.CreateGraphAsync(...)            // Create graph
client.SubpackageGraph.ListAllGraphsAsync(...)          // List all graphs

// Entity management
client.SubpackageEntity.GetEdgeAsync(...)               // Get edge
client.SubpackageEntity.GetNodeAsync(...)               // Get node
client.SubpackageEntity.AddFactTripleAsync(...)         // Add fact triple

// Context templates
client.SubpackageContext.CreateContextTemplateAsync(...)
client.SubpackageContext.ListContextTemplatesAsync(...)

// Project info
client.SubpackageProject.RetrievesProjectInformationAsync(...)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsAddMemoryTool()` -- Add text data to a user's knowledge graph memory
- `AsSearchMemoryTool()` -- Search a user's knowledge graph for relevant facts
- `AsGetContextTool()` -- Get relevant context from a thread's conversation history
- `AsListThreadsTool()` -- List all conversation threads with pagination
- `AsGetUserNodeTool()` -- Get a user's central node from the knowledge graph
- `AsAddMessagesTool()` -- Add a message to a conversation thread
