using Microsoft.EntityFrameworkCore;
using NpsApi.Dominio;

namespace NpsApi.Repositorio
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Revisao> Revisoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Revisao>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Revisao>()
                .Property(r => r.NomeProduto)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Revisao>()
                .Property(r => r.Score)
                .IsRequired();
        }
    }
}
