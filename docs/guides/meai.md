# Microsoft.Extensions.AI Integration

The Zep SDK provides `AIFunction` tool wrappers that can be used with any `IChatClient` implementation
from the Microsoft.Extensions.AI ecosystem. These tools enable AI agents to interact with Zep's
knowledge graph memory during conversations.

## Available Tools

| Tool | Method | Description |
|------|--------|-------------|
| `Zep_AddMemory` | `AsAddMemoryTool()` | Add text data to a user's knowledge graph memory |
| `Zep_SearchMemory` | `AsSearchMemoryTool()` | Search a user's knowledge graph for relevant facts |
| `Zep_GetContext` | `AsGetContextTool()` | Get relevant context from a thread's conversation history |
| `Zep_ListThreads` | `AsListThreadsTool()` | List all conversation threads with pagination |
| `Zep_GetUserNode` | `AsGetUserNodeTool()` | Get a user's central node from the knowledge graph |
| `Zep_AddMessages` | `AsAddMessagesTool()` | Add a message to a conversation thread |

## Usage Example

```csharp
using Microsoft.Extensions.AI;
using Zep;

// Create the Zep client
using var zepClient = new ZepClient(apiKey: "z_your_api_key");

// Create tools
var tools = new AITool[]
{
    zepClient.AsSearchMemoryTool(),
    zepClient.AsGetContextTool(),
    zepClient.AsAddMemoryTool(),
};

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
var chatClient = new OpenAIClient(openAiKey)
    .GetChatClient("gpt-4o")
    .AsIChatClient();

var response = await chatClient.GetResponseAsync(
    "What do you remember about the user's preferences?",
    new() { Tools = tools });
```

## Tool Details

### AsAddMemoryTool

Adds text data to a user's Zep knowledge graph. The data will be automatically processed
and facts/entities will be extracted.

**Parameters:**
- `data` (string) -- The text content to add to memory
- `userId` (string) -- The user ID to add memory for
- `sourceDescription` (string, optional) -- Description of the data source

### AsSearchMemoryTool

Searches a user's knowledge graph for relevant facts, entities, and relationships.

**Parameters:**
- `query` (string) -- The search query string
- `userId` (string) -- The user ID to search memories for
- `limit` (int, optional) -- Maximum number of results (default 10, max 50)

### AsGetContextTool

Gets relevant context from the user's knowledge graph based on recent messages in a thread.

**Parameters:**
- `threadId` (string) -- The thread ID to get context for

### AsListThreadsTool

Lists all conversation threads with pagination support.

**Parameters:**
- `pageNumber` (int, optional) -- Page number for pagination
- `pageSize` (int, optional) -- Page size for pagination

### AsGetUserNodeTool

Gets a user's central node from the Zep knowledge graph, including their summary.

**Parameters:**
- `userId` (string) -- The user ID to get the node for

### AsAddMessagesTool

Adds a message to a conversation thread. The message will be processed and relevant
facts will be extracted to the user's knowledge graph.

**Parameters:**
- `threadId` (string) -- The thread ID to add messages to
- `content` (string) -- The message content
- `role` (string) -- The role of the sender (e.g., "user", "assistant")
