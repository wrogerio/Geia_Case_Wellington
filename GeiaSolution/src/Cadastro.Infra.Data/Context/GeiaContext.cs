using Cadastro.Domain.Entities;
using Cadastro.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infra.Data.Context
{
    public class GeiaContext : DbContext
    {
        // Set DBSet
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ProdutosDB;User ID=sa;PWD=spnsw2002");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
        }
    }
}