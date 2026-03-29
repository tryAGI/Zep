# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Zep SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Zep's knowledge graph memory -- adding data, searching facts, retrieving context, managing threads, and inspecting user nodes.

## Installation

```bash
dotnet add package Zep
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsAddMemoryTool()` | `Zep_AddMemory` | Add text data to a user's knowledge graph memory |
| `AsSearchMemoryTool()` | `Zep_SearchMemory` | Search a user's knowledge graph for relevant facts and relationships |
| `AsGetContextTool()` | `Zep_GetContext` | Get relevant context from a thread's conversation history |
| `AsListThreadsTool()` | `Zep_ListThreads` | List all conversation threads with pagination |
| `AsGetUserNodeTool()` | `Zep_GetUserNode` | Get a user's central node from the knowledge graph |
| `AsAddMessagesTool()` | `Zep_AddMessages` | Add a message to a conversation thread |

## Usage

```csharp
using Zep;
using Microsoft.Extensions.AI;

var zepClient = new ZepClient(
    apiKey: Environment.GetEnvironmentVariable("ZEP_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        zepClient.AsAddMemoryTool(),
        zepClient.AsSearchMemoryTool(),
        zepClient.AsGetContextTool(),
        zepClient.AsListThreadsTool(),
        zepClient.AsGetUserNodeTool(),
        zepClient.AsAddMessagesTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Search the memory for user 'user-42' about their project preferences."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
