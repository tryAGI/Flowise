namespace Flowise.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static FlowiseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FLOWISE_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("FLOWISE_API_KEY environment variable is not found.");

        var client = new FlowiseClient(authorizations: [
            new EndPointAuthorization
            {
                Type = "Http",
                Name = "Bearer",
                Value = apiKey,
            },
        ]);

        return client;
    }
}
