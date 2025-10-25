using Microsoft.EntityFrameworkCore;

namespace Crisnamart.DB;

public class CrisnamartContext : DbContext {
	public DbSet<Producto> Productos => Set<Producto>();
	public DbSet<Cliente> Clientes => Set<Cliente>();
	public DbSet<Pedido> Pedidos => Set<Pedido>();
	public DbSet<PedidoItem> PedidoItems => Set<PedidoItem>();

	public CrisnamartContext(DbContextOptions<CrisnamartContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		// Productos
		modelBuilder.Entity<Producto>(entity => {
			entity.Property(p => p.CodigoUnico).IsRequired().HasMaxLength(50);
			entity.Property(p => p.Descripcion).IsRequired().HasMaxLength(255);
		});

		// Clientes
		modelBuilder.Entity<Cliente>(entity => {
			entity.Property(c => c.RazonSocial).HasMaxLength(150);
			entity.HasMany(c => c.Pedidos)
				  .WithOne(p => p.Cliente!)
				  .HasForeignKey(p => p.ClienteId)
				  .OnDelete(DeleteBehavior.Cascade);
		});

		// Pedidos
		modelBuilder.Entity<Pedido>(entity => {
			entity.HasMany(p => p.Items)
				  .WithOne(i => i.Pedido!)
				  .HasForeignKey(i => i.PedidoId)
				  .OnDelete(DeleteBehavior.Cascade);
		});

		// PedidoItems
		modelBuilder.Entity<PedidoItem>(entity => {
			entity.HasOne(i => i.Producto)
				  .WithMany()
				  .HasForeignKey(i => i.ProductoId);
		});
	}
}
