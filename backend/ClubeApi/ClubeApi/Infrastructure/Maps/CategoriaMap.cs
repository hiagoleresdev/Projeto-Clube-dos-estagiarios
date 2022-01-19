using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infrastructure.Maps
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //Especificações da entidade Categoria
            builder.ToTable("Categorias");

            builder.HasKey(categoria => categoria.Id);

            builder.Property(categoria => categoria.Tipo)
                .HasColumnName("tipo")
                .HasColumnType("VARCHAR(10)")
                .IsRequired();
        }
    }
}
