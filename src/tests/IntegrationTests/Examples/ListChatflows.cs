/*
order: 20
title: List Chatflows
slug: list-chatflows
*/

namespace Flowise.IntegrationTests;

public partial class Tests
{
    //// Retrieve all chatflows configured in your Flowise instance.

    [TestMethod]
    public async Task Example_ListChatflows()
    {
        using var client = GetAuthenticatedClient();

        var chatflows = await client.Chatflows.ListChatflowsAsync();

        chatflows.Should().NotBeNull();

        foreach (var chatflow in chatflows)
        {
            Console.WriteLine($"Chatflow: {chatflow.Name} (ID: {chatflow.Id})");
        }
    }
}
