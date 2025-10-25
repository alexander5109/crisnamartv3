using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// --- Blazor setup ---
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

// --- HttpClient to reach the API ---
builder.Services.AddHttpClient("ApiClient", client => {
	string? apiBaseUrl = builder.Configuration["ApiBaseUrl"];
	if (string.IsNullOrEmpty(apiBaseUrl)){
		throw new InvalidOperationException(
		"❌ ApiBaseUrl ['ApiBaseUrl'] no se encontró. Fijarse el appsettings.json que corresponda.");
	}
	client.BaseAddress = new Uri(apiBaseUrl);
})
.ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler {
	ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
});

var app = builder.Build();

// --- pipeline ---
if (!app.Environment.IsDevelopment()) {
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// --- map razor components ---
app.MapRazorComponents<Crisnamart.BlazorClient.Components.App>()
   .AddInteractiveServerRenderMode();

app.Run();
