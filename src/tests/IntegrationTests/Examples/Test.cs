/*
order: 10
title: Test
slug: test
*/

namespace Flowise.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();
    }
}
