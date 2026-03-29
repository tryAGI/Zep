/*
order: 20
title: Graph Search
slug: graph-search

Example showing how to search a user's knowledge graph.
*/

namespace Zep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GraphSearch()
    {
        //// Create a Zep client with your API key.
        using var client = GetAuthenticatedClient();

        //// Add data to a user's knowledge graph.
        var userId = "test-user-" + Guid.NewGuid().ToString("N")[..8];

        await client.SubpackageUser.AddAsync(
            userId: userId,
            firstName: "Graph",
            lastName: "User");

        await client.SubpackageData.AddDataAsync(
            data: "Alice works at Acme Corp as a software engineer. She joined in 2023.",
            type: ModelsGraphDataType.Text,
            userId: userId,
            sourceDescription: "user_profile");

        //// Search the user's knowledge graph for relevant facts.
        var results = await client.SubpackageSearch.GraphAsync(
            query: "Where does Alice work?",
            userId: userId,
            limit: 5);
        results.Should().NotBeNull();
    }
}
