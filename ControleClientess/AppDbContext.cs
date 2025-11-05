using Microsoft.EntityFrameworkCore;

namespace ControleClientess
{
    class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dados;Username=postgres;Password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Cidade)
            .WithMany(c => c.Clientes)
            .HasForeignKey(c => c.CidadeId);
        }
    }
}
