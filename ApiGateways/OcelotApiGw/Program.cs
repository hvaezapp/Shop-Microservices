using Ocelot.Middleware;
using OcelotApiGw.Registration;

var builder = WebApplication.CreateBuilder(args);

// register ocelot route json file configuration
builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
// register logging
builder.Logging.RegisterLogging(builder.Configuration);
// register ocelot
builder.Services.RegisterOcelot();

var app = builder.Build();

app.UseRouting();

// use ocelot
await app.UseOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();
