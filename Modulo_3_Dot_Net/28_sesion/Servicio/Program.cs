using Serilog;
using Servicio.Sensor;
using Serviciio.Matrics;


// Create a host builder
var builder = Host.CreateAplicationBuilder(args);

// Configure logging
long.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuratio)
    .WriteTo.Console()
    .WriteTo.File(
        path: "logs/termicologs-.csv",
        outputTemplate: "{Timestamp:0};{Message.1}{NewLine}",
        rollingInterval: RollingInterval.Day
    ).CreateLogger();

// Configure services
builder.Loggin.ClearProviders();
// Add Serilog as the logging provider
builder.Loggin.AddSerilog();
