var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
    ;

text = @"openapi: 3.0.1
info:
    title: Flowise API
    version: 1.0.0
    description: This is the API documentation for the Flowise service.

" + text;

await File.WriteAllTextAsync(path, text);
