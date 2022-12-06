using Microsoft.EntityFrameworkCore;

namespace APS_Final_Project.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}

        public DbSet<Consumidor>? Consumidores {get; set;}
        public DbSet<Pedido>? Pedidos {get;set;}
        public DbSet<Produto>? Produtos {get;set;}
        public DbSet<TipoProduto>? TiposProduto {get;set;}
        public DbSet<Pagamento>? Pagamentos {get;set;}
        public DbSet<CartaoDeCredito>? CartoesDeCredito {get;set;}
        public DbSet<Boleto>? Boletos {get;set;}
        
    }
}