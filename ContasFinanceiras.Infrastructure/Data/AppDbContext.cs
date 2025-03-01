using ContasFinanceiras.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContasFinanceiras.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<ContaFinanceira> ContasFinanceiras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Investimento> Investimentos { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Anexo> Anexos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento entre ContaFinanceira e Categoria (1:N)
            modelBuilder.Entity<ContaFinanceira>()
                .HasOne(cf => cf.Categoria)
                .WithMany(c => c.ContasFinanceiras)
                .HasForeignKey(cf => cf.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre ContaFinanceira e Carteira (1:N)
            modelBuilder.Entity<ContaFinanceira>()
                .HasOne(cf => cf.Carteira)
                .WithMany(c => c.ContasFinanceiras)
                .HasForeignKey(cf => cf.CarteiraId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento entre Anexo e ContaFinanceira (1:N)
            modelBuilder.Entity<Anexo>()
                .HasOne(a => a.ContaFinanceira)
                .WithMany(cf => cf.Anexos)
                .HasForeignKey(a => a.ContaFinanceiraId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
