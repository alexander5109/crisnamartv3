using Crisnamart.DB;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// ==============================
// 🔧 CONFIGURACIÓN BASE
// ==============================

// Leer cadena de conexión desde appsettings.json
string? connectionString = builder.Configuration.GetConnectionString("MySql");

if (string.IsNullOrWhiteSpace(connectionString)) {
	throw new InvalidOperationException(
		"❌ Connection string 'ConnectionStrings:MySql' no se encontró. Verifica el archivo appsettings.json.");
}
ServerVersion serverVersion;
try {
	serverVersion = ServerVersion.AutoDetect(connectionString);
} catch (MySqlException ex) {
	// log or show friendly error
	Console.WriteLine("No se pudo detectar la versión del servidor MySQL. Verifique que el servicio esté activo.");
	Console.WriteLine(ex.Message);

	// Decide: either throw, or set a fallback version
	throw new InvalidOperationException("Error inicializando la conexión a MySQL.", ex);
}

// ==============================
// 📦 REGISTRO DE SERVICIOS
// ==============================

// Contexto de base de datos
builder.Services.AddDbContext<CrisnamartContext>(options =>
	options.UseMySql(connectionString, serverVersion));


// Repositorios
builder.Services.AddScoped<IRepository<Producto>, Repository<Producto>>();
builder.Services.AddScoped<ProductoRepository>();

// Controladores y herramientas
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ==============================
// 🚀 CONSTRUCCIÓN DE LA APP
// ==============================

var app = builder.Build();

// ==============================
// ⚙️ CONFIGURACIÓN DEL PIPELINE
// ==============================

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

// ==============================
// 🧠 PRUEBA DE CONEXIÓN (opcional pero útil)
// ==============================
try {
	using (var scope = app.Services.CreateScope()) {
		var db = scope.ServiceProvider.GetRequiredService<CrisnamartContext>();
		if (!db.Database.CanConnect())
			Console.WriteLine("⚠️ Advertencia: No se pudo establecer conexión con la base de datos MySQL.");
		else
			Console.WriteLine("✅ Conectado correctamente a la base de datos MySQL.");
	}
} catch (Exception ex) {
	Console.WriteLine($"❌ Error al conectar a la base de datos: {ex.Message}");
}

app.Run();
