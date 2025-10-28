using Crisnamart.Domain;
using Crisnamart.BlazorWasm.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Punto de entrada de tu app Blazor
builder.RootComponents.Add<App>("#app");

// --- HttpClient para la API ---
string? apiBaseUrl = builder.Configuration["ApiBaseUrl"];
if (string.IsNullOrEmpty(apiBaseUrl)) {
	// Para prototipo sin API, podemos usar localhost o base temporal
	apiBaseUrl = builder.HostEnvironment.BaseAddress;
}

builder.Services.AddScoped(sp => new HttpClient {
	BaseAddress = new Uri(apiBaseUrl)
});

// --- Servicios de tu dominio (datos hardcodeados) ---
builder.Services.AddSingleton<PrototipoContenido>(); // Ejemplo: un service que expone tus listas hardcodeadas

// --- Logging y manejo de errores globales opcional ---
builder.Logging.SetMinimumLevel(LogLevel.Warning);

await builder.Build().RunAsync();
