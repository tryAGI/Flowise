/*
order: 40
title: Ping Server
slug: ping-server
*/

namespace Flowise.IntegrationTests;

public partial class Tests
{
    //// Check if the Flowise server is alive by pinging it.

    [TestMethod]
    public async Task Example_PingServer()
    {
        using var client = GetAuthenticatedClient();

        string pong = await client.Ping.PingServerAsync();

        pong.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Ping response: {pong}");
    }
}
