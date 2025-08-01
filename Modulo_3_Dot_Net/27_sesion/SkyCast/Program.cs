using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SkyCast;
using SkyCast.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuración de servicios
builder.Services.AddScoped<WeatherService>(); 
builder.Services.AddHttpClient<WeatherService>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Configuración de la clave de la API de OpenWeather 
var envKey = builder.Configuration["OpenWeather:key"];

await builder.Build().RunAsync();