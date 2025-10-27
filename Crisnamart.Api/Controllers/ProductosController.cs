using Crisnamart;
using Crisnamart.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crisnamart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase {
	private readonly DB.CrisnamartContext _context;

	public ProductosController(DB.CrisnamartContext context) {
		_context = context;
	}



	[HttpGet]
	public async Task<ActionResult<IEnumerable<Producto>>> GetAll() {
		try {
			var productos = await _context.Productos.AsNoTracking().ToListAsync();
			if (productos.Count == 0)
				return NotFound("No hay productos cargados en la base de datos.");
			return Ok(productos);
		} catch (Exception ex) {
			// You could log ex here
			return StatusCode(500, "Error al obtener productos. Verifique que la base de datos esté en funcionamiento.");
		}
	}



	[HttpGet("{id:int}")]
	public async Task<ActionResult<Producto>> GetById(int id) {
		try {
			var producto = await _context.Productos.FindAsync(id);
			return producto == null ? NotFound() : Ok(producto);
		} catch (Exception ex) {
			// Log ex here if needed
			return StatusCode(500, "Error al obtener el producto. Verifique que la base de datos esté en funcionamiento.");
		}
	}






}
