/*
order: 10
title: Users and Threads
slug: users-and-threads

Basic example showing how to create users, threads, and add messages.
*/

namespace Zep.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_UsersAndThreads()
    {
        //// Create a Zep client with your API key.
        using var client = GetAuthenticatedClient();

        //// Create a user to associate with threads.
        var user = await client.SubpackageUser.AddAsync(
            userId: "test-user-" + Guid.NewGuid().ToString("N")[..8],
            firstName: "Test",
            lastName: "User",
            email: "test@example.com");
        user.Should().NotBeNull();

        //// Start a new thread for the user.
        var thread = await client.SubpackageThread.StartANewThreadAsync(
            threadId: "thread-" + Guid.NewGuid().ToString("N")[..8],
            userId: user.UserId!);
        thread.Should().NotBeNull();

        //// Add messages to the thread.
        var response = await client.SubpackageThread.AddMessagesToAThreadAsync(
            threadId: thread.ThreadId!,
            messages:
            [
                new ApidataThreadMessage
                {
                    Content = "Hi, I'm interested in learning about temporal knowledge graphs.",
                    Role = ApidataRoleType.User,
                },
                new ApidataThreadMessage
                {
                    Content = "Temporal knowledge graphs track how facts and relationships change over time.",
                    Role = ApidataRoleType.Assistant,
                },
            ],
            returnContext: true);
        response.Should().NotBeNull();

        //// Get context for the thread based on recent messages.
        var context = await client.SubpackageThread.GetUserContextAsync(
            threadId: thread.ThreadId!);
        context.Should().NotBeNull();
    }
}
