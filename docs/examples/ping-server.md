# Ping Server



This example assumes `using Flowise;` is in scope and `apiKey` contains your Flowise API key.

```csharp
using var client = new FlowiseClient(apiKey);

string pong = await client.Ping.PingServerAsync();

Console.WriteLine($"Ping response: {pong}");
```