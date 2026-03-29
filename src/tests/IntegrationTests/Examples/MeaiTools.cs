/*
order: 30
title: MEAI Tools
slug: meai-tools

Example showing how to use Zep as AIFunction tools with any IChatClient.
*/

namespace Zep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiTools()
    {
        //// Create a Zep client with your API key.
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient.
        var addMemoryTool = client.AsAddMemoryTool();
        addMemoryTool.Should().NotBeNull();
        addMemoryTool.Name.Should().Be("Zep_AddMemory");

        var searchMemoryTool = client.AsSearchMemoryTool();
        searchMemoryTool.Should().NotBeNull();
        searchMemoryTool.Name.Should().Be("Zep_SearchMemory");

        var getContextTool = client.AsGetContextTool();
        getContextTool.Should().NotBeNull();
        getContextTool.Name.Should().Be("Zep_GetContext");

        var listThreadsTool = client.AsListThreadsTool();
        listThreadsTool.Should().NotBeNull();
        listThreadsTool.Name.Should().Be("Zep_ListThreads");

        var getUserNodeTool = client.AsGetUserNodeTool();
        getUserNodeTool.Should().NotBeNull();
        getUserNodeTool.Name.Should().Be("Zep_GetUserNode");

        var addMessagesTool = client.AsAddMessagesTool();
        addMessagesTool.Should().NotBeNull();
        addMessagesTool.Name.Should().Be("Zep_AddMessages");

        //// These tools can be passed to any IChatClient for function calling:
        //// var chatResponse = await chatClient.GetResponseAsync(
        ////     "What do you remember about Alice?",
        ////     new() { Tools = [searchMemoryTool, getContextTool] });
    }
}
