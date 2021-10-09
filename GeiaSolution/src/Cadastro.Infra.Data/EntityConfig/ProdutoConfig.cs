using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cadastro.Infra.Data.EntityConfig
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // Key
            builder.HasKey(x => x.Id);

            // Required
            builder.Property(x => x.Empresa).IsRequired();
            builder.Property(x => x.NumeroRegristro).IsRequired();
            builder.Property(x => x.Preco).IsRequired();
            builder.Property(x => x.Empresa).IsRequired();

            // MaxLength
            builder.Property(x => x.Nome).HasMaxLength(70);
            builder.Property(x => x.Empresa).HasMaxLength(70);
            builder.Property(x => x.NumeroRegristro).HasMaxLength(20);

            // Column Type
            builder.Property(x => x.CreatedAt).HasColumnType("DateTime");
            builder.Property(x => x.DataValidade).HasColumnType("DateTime");
            builder.Property(x => x.UpdatedAt).HasColumnType("DateTime");
            builder.Property(x => x.Preco).HasColumnType("Decimal(18,2)");

            // Default Value
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Deleted).HasDefaultValue(0);
        }
    }
}