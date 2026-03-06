using Microsoft.EntityFrameworkCore;
using PDV.Models;

namespace PDV.Infra.Context
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Estoque> _Estoque => Set<Estoque>();
        public DbSet<EstoqueDiario> _EstoqueDiario => Set<EstoqueDiario>();
        public DbSet<ItensPedido> _ItensPedido => Set<ItensPedido>();
        public DbSet<MovimentacaoEstoque> _MovimentacaoEstoque => Set<MovimentacaoEstoque>();
        public DbSet<Pedido> _Pedido => Set<Pedido>();
        public DbSet<Produto> _Produto => Set<Produto>();
        public DbSet<ProdutoComposicao> _ProdutoComposicao => Set<ProdutoComposicao>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estoque>()
                .HasKey(e => e.ID_Produto);
            modelBuilder.Entity<EstoqueDiario>()
                .HasKey(ed => new { ed.ID_Produto, ed.Data_Estoque });
            modelBuilder.Entity<ItensPedido>()
                .HasKey(ip => new { ip.ID_Pedido, ip.Data_Pedido, ip.ID_Itens_Pedido });
            modelBuilder.Entity<MovimentacaoEstoque>()
                .HasKey(me => new { me.ID_Produto, me.Lancto_Movimentacao });
        }
    }
}
