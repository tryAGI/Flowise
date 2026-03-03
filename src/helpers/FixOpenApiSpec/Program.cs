using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
        .Replace(@"
                content:
                    application/json:
                        schema:
                            $ref: '#/components/schemas/ChatMessageFeedback'", @"
                    content:
                        application/json:
                            schema:
                                $ref: '#/components/schemas/ChatMessageFeedback'")
        .Replace(@"
                content:
                    application/json:
                        schema:
                            type: array
                            items:
                                $ref: '#/components/schemas/DocumentStore'", @"
                    content:
                        application/json:
                            schema:
                                type: array
                                items:
                                    $ref: '#/components/schemas/DocumentStore'")
    ;

text = @"openapi: 3.0.1
info:
    title: Flowise API
    version: 1.0.0
    description: This is the API documentation for the Flowise service.
    
" + text;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;