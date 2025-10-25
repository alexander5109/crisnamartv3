using Microsoft.EntityFrameworkCore;

namespace Crisnamart.DB;

public interface IRepository<T> where T : class {
	Task<IEnumerable<T>> GetAllAsync();
	Task<T?> GetByIdAsync(int id);
	Task AddAsync(T entity);
	Task UpdateAsync(T entity);
	Task DeleteAsync(int id);
	Task SaveChangesAsync();
}




public class Repository<T> : IRepository<T> where T : class {
	private readonly CrisnamartContext _context;
	private readonly DbSet<T> _set;

	public Repository(CrisnamartContext context) {
		_context = context;
		_set = context.Set<T>();

		// Fail fast if DB is unreachable
		try {
			// simple synchronous check
			if (!_context.Database.CanConnect())
				throw new InvalidOperationException("No se puede conectar a la base de datos MySQL.");
		} catch (Exception ex) {
			throw new InvalidOperationException("Error inicializando el repositorio: " + ex.Message, ex);
		}
	}

	public async Task<IEnumerable<T>> GetAllAsync() => await _set.ToListAsync();

	public async Task<T?> GetByIdAsync(int id) => await _set.FindAsync(id);

	public async Task AddAsync(T entity) => await _set.AddAsync(entity);

	public async Task UpdateAsync(T entity) => _context.Entry(entity).State = EntityState.Modified;

	public async Task DeleteAsync(int id) {
		var entity = await GetByIdAsync(id);
		if (entity != null)
			_set.Remove(entity);
	}

	public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}














public class ProductoRepository(CrisnamartContext context) : Repository<Producto>(context) {
	public async Task<IEnumerable<Producto>> SearchAsync(string term) {
		return await context.Productos
			.Where(p => p.Descripcion.Contains(term) || p.CodigoUnico.Contains(term))
			.ToListAsync();
	}

	private readonly CrisnamartContext context;
}
