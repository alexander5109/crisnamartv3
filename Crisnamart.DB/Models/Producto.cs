namespace Crisnamart.DB.Models;

public class Producto {
	public int Id { get; set; }
	public string CodigoUnico { get; set; } = "";
	public string Ruta { get; set; } = "";
	public string Descripcion { get; set; } = "";
}