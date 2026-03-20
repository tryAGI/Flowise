# List Chatflows



This example assumes `using Flowise;` is in scope and `apiKey` contains your Flowise API key.

```csharp
using var client = new FlowiseClient(apiKey);

var chatflows = await client.Chatflows.ListChatflowsAsync();

foreach (var chatflow in chatflows)
{
    Console.WriteLine($"Chatflow: {chatflow.Name} (ID: {chatflow.Id})");
}
```