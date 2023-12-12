# Issue 2434

The steps on the issue are incorrect.

It was missing a step to register the service in the client project Program.cs

```
builder.Services.AddScoped<RazorLib1.ExampleJsInterop>();
```