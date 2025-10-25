using System.ComponentModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// --- map razor components ---
app.MapRazorComponents<Crisnamart.BlazorClient.Components.App>()
   .AddInteractiveServerRenderMode();

app.Run();
