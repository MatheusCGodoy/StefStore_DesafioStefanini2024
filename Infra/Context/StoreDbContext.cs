using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infra.Context;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Produto[] produtos = new Produto[]
        {
            new Produto(1, "Produto1", (decimal) 10.50, new List<ItensPedido>()),
            new Produto(2, "Produto2", (decimal) 20.50, new List<ItensPedido>()),
            new Produto(3, "Produto3", (decimal) 30.50, new List<ItensPedido>()),
            new Produto(4, "Produto4", (decimal) 40.50, new List<ItensPedido>()),
            new Produto(5, "Produto5", (decimal) 50.50, new List<ItensPedido>()),
        };
        modelBuilder.Entity<Produto>().HasData(produtos);

        modelBuilder.Entity<ItensPedido>()
            .HasOne(itemPedido => itemPedido.Pedido)
            .WithMany(pedido => pedido.ItensPedido)
            .HasForeignKey(itemPedido => itemPedido.PedidoId);

        modelBuilder.Entity<ItensPedido>()
            .HasOne(itemPedido => itemPedido.Produto)
            .WithMany(produto => produto.ItensPedido)
            .HasForeignKey(itensPedido => itensPedido.ProdutoId);

        //base.OnModelCreating(modelBuilder);
    }

    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ItensPedido> ItensPedido { get; set; }
}
