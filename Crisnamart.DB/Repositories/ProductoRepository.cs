using Dapper;
using MySqlConnector;

namespace Crisnamart.DB.Repositories;

public class ProductoRepository {
	private readonly string _connectionString;
	public ProductoRepository(string connectionString) => _connectionString = connectionString;

	public async Task<IEnumerable<Models.Producto>> GetAllAsync() {
		using var connection = new MySqlConnection(_connectionString);
		return await connection.QueryAsync<Models.Producto>("SELECT * FROM Productos");
	}
}
