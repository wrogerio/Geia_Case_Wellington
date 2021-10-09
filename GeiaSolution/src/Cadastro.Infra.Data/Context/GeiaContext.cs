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
            optionsBuilder.UseSqlServer(BuildConnectionString(@".\", "sa", "spnsw2002"));
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
        }

        protected string BuildConnectionString(string instanceSQL, string userName, string password)
        {
            return $"Data Source={instanceSQL};Initial Catalog=ProdutosDB;User ID={userName};PWD={password}";
        }
    }
}