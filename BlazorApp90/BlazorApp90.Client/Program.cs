using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<RazorLib1.ExampleJsInterop>();

await builder.Build().RunAsync();
