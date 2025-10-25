using System;
using System.Collections.Generic;

namespace Crisnamart.DB;

public class Producto {
	public int Id { get; set; }
	public string CodigoUnico { get; set; } = "";
	public string Ruta { get; set; } = "";
	public string Descripcion { get; set; } = "";
}

public class Cliente {
	public int Id { get; set; }
	public string CodigoUnico { get; set; } = "";
	public string CUIT { get; set; } = "";
	public string RazonSocial { get; set; } = "";
	public string Nombre { get; set; } = "";
	public string Apellido { get; set; } = "";
	public string Direccion { get; set; } = "";
	public List<Pedido> Pedidos { get; set; } = new();
}

public class Pedido {
	public int Id { get; set; }
	public DateTime Fecha { get; set; } = DateTime.Now;
	public string Estado { get; set; } = "Pendiente";

	// Relaciones
	public int ClienteId { get; set; }
	public Cliente? Cliente { get; set; }
	public List<PedidoItem> Items { get; set; } = new();
}

public class PedidoItem {
	public int Id { get; set; }
	public int PedidoId { get; set; }
	public Pedido? Pedido { get; set; }

	public int ProductoId { get; set; }
	public Producto? Producto { get; set; }

	public int Cantidad { get; set; }
	public decimal PrecioUnitario { get; set; }
}
