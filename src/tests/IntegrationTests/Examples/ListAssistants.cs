/*
order: 30
title: List Assistants
slug: list-assistants
*/

namespace Flowise.IntegrationTests;

public partial class Tests
{
    //// Retrieve all assistants configured in your Flowise instance.

    [TestMethod]
    public async Task Example_ListAssistants()
    {
        using var client = GetAuthenticatedClient();

        var assistants = await client.Assistants.ListAssistantsAsync();

        assistants.Should().NotBeNull();

        foreach (var assistant in assistants)
        {
            Console.WriteLine($"Assistant: {assistant.Name} (ID: {assistant.Id})");
        }
    }
}
