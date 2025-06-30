using EstoqueApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueApp.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("ID");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Nome");

            builder.HasIndex(c => c.Nome)
                .IsUnique();

        }
    }
}
