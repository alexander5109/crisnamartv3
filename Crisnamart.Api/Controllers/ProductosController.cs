using Microsoft.AspNetCore.Mvc;
using Crisnamart.DB.Repositories;

namespace Crisnamart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase {
	private readonly ProductoRepository _repo;

	public ProductosController(ProductoRepository repo) {
		_repo = repo;
	}

	[HttpGet]
	public async Task<IActionResult> Get() {
		var productos = await _repo.GetAllAsync();
		return Ok(productos);
	}
}
