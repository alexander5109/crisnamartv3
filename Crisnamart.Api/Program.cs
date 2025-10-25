using Crisnamart.DB.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();                   // Enable controllers
builder.Services.AddEndpointsApiExplorer();          // For Swagger
builder.Services.AddSwaggerGen();                    // Swagger generator

// Connection string (reads from appsettings.json)

string? connectionString = builder.Configuration.GetConnectionString("MySql");

if (string.IsNullOrWhiteSpace(connectionString)) {
	throw new InvalidOperationException(
		"❌ Connection string 'ConectionStrings['MySql']' no se encontró. Fijarse el appsettings.json que corresponda.");
}




builder.Services.AddSingleton(new ProductoRepository(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();                                // Map controller routes
app.Run();
