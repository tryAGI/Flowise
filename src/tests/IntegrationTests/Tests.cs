namespace Flowise.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static FlowiseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FLOWISE_API_KEY") ??
            throw new AssertInconclusiveException("FLOWISE_API_KEY environment variable is not found.");

        var client = new FlowiseClient(apiKey);
        
        return client;
    }
}
