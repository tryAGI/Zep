#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Zep;

/// <summary>
/// MEAI AIFunction tool extensions for ZepClient.
/// </summary>
public static class ZepClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that adds data to a user's knowledge graph.
    /// </summary>
    public static AIFunction AsAddMemoryTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The data/text content to add to memory")] string data,
                   [Description("The user ID to add memory for")] string userId,
                   [Description("Optional description of the data source")] string? sourceDescription,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageData.AddDataAsync(
                    data: data,
                    type: ModelsGraphDataType.Text,
                    userId: userId,
                    sourceDescription: sourceDescription,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Uuid,
                    response.CreatedAt,
                    response.Source,
                    response.SourceDescription,
                };
            },
            name: "Zep_AddMemory",
            description: "Add text data to a user's Zep knowledge graph memory. The data will be processed and facts/entities will be extracted automatically.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches the knowledge graph.
    /// </summary>
    public static AIFunction AsSearchMemoryTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The search query string")] string query,
                   [Description("The user ID to search memories for")] string userId,
                   [Description("Maximum number of results to return (default 10, max 50)")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageSearch.GraphAsync(
                    query: query,
                    userId: userId,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Edges = response.Edges?.Select(e => new
                    {
                        e.Uuid,
                        e.Name,
                        e.Fact,
                        e.CreatedAt,
                        e.ExpiredAt,
                    }),
                    Nodes = response.Nodes?.Select(n => new
                    {
                        n.Uuid,
                        n.Name,
                        n.Summary,
                    }),
                };
            },
            name: "Zep_SearchMemory",
            description: "Search a user's Zep knowledge graph memory for relevant facts, entities, and relationships using a natural language query.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the context for a thread.
    /// </summary>
    public static AIFunction AsGetContextTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The thread ID to get context for")] string threadId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageThread.GetUserContextAsync(
                    threadId: threadId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Context,
                };
            },
            name: "Zep_GetContext",
            description: "Get relevant context from a user's Zep knowledge graph based on the recent messages in a thread. Returns facts, entities, and relevant conversation history.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists threads.
    /// </summary>
    public static AIFunction AsListThreadsTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Page number for pagination (optional)")] int? pageNumber,
                   [Description("Page size for pagination (optional)")] int? pageSize,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageThread.GetThreadsAsync(
                    pageNumber: pageNumber,
                    pageSize: pageSize,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Zep_ListThreads",
            description: "List all conversation threads in Zep with pagination support.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a user's knowledge graph node.
    /// </summary>
    public static AIFunction AsGetUserNodeTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The user ID to get the knowledge graph node for")] string userId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageUser.GetUserNodeAsync(
                    userId: userId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    NodeUuid = response.Node?.Uuid,
                    NodeName = response.Node?.Name,
                    NodeSummary = response.Node?.Summary,
                };
            },
            name: "Zep_GetUserNode",
            description: "Get a user's central node from the Zep knowledge graph, including their summary and metadata.");
    }

    /// <summary>
    /// Creates an AIFunction tool that adds messages to a thread.
    /// </summary>
    public static AIFunction AsAddMessagesTool(this ZepClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The thread ID to add messages to")] string threadId,
                   [Description("The message content to add")] string content,
                   [Description("The role of the message sender (e.g., 'user', 'assistant')")] string role,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageThread.AddMessagesToAThreadAsync(
                    threadId: threadId,
                    messages:
                    [
                        new ApidataThreadMessage
                        {
                            Content = content,
                            Role = role switch
                            {
                                "user" => ApidataRoleType.User,
                                "assistant" => ApidataRoleType.Assistant,
                                "system" => ApidataRoleType.System,
                                "function" => ApidataRoleType.Function,
                                "tool" => ApidataRoleType.Tool,
                                _ => ApidataRoleType.Norole,
                            },
                        },
                    ],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Context,
                    response.MessageUuids,
                    response.TaskId,
                };
            },
            name: "Zep_AddMessages",
            description: "Add a message to a Zep conversation thread. The message will be processed and relevant facts will be extracted to the user's knowledge graph.");
    }
}
