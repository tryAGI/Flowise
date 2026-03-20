# List Assistants



This example assumes `using Flowise;` is in scope and `apiKey` contains your Flowise API key.

```csharp
using var client = new FlowiseClient(apiKey);

var assistants = await client.Assistants.ListAssistantsAsync();

foreach (var assistant in assistants)
{
    Console.WriteLine($"Assistant: {assistant.Id} (Credential: {assistant.Credential})");
}
```