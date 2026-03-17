using ConductorAI.Api.Connectors;
using ConductorAI.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HueSettings>(builder.Configuration.GetSection(HueSettings.Section));
builder.Services.Configure<WeatherSettings>(builder.Configuration.GetSection(WeatherSettings.Section));
builder.Services.Configure<OllamaSettings>(builder.Configuration.GetSection(OllamaSettings.Section));
builder.Services.Configure<AuthSettings>(builder.Configuration.GetSection(AuthSettings.Section));

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();


// Cross-platform services, we will always register these


// Windows-only services, only register these if we're on Windows
#if WINDOWS
builder.Services.AddSingleton<IDeviceConnector, WindowsMediaConnector>();
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.Run();
