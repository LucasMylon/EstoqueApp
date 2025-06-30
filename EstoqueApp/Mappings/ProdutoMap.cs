using EstoqueApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueApp.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto> 
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id);

            builder.Property(p => p.Nome).IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Preco).IsRequired().HasColumnType("decimal(10,2)");

            builder.Property(p => p.Quantidade).IsRequired();

            builder.Property(p => p.CategoriaId)
                .IsRequired();

        }
    }
}

