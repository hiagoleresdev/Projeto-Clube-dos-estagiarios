using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infrastructure.Maps
{
    public class DependenteMap : IEntityTypeConfiguration<Dependente>
    {
        public void Configure(EntityTypeBuilder<Dependente> builder)
        {
            //Especificações da entidade Dependente
            builder.ToTable("dependentes");

            builder.Property(socio => socio.NumeroCartao)
                .HasColumnName("cartao")
                .HasColumnType("NUMERIC(9)")
                .IsRequired();

            builder.Property(dependente => dependente.Parentesco)
                .HasColumnName("parentesco")
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property<int>("fkSocio")
                .HasColumnName("fkSocio")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.HasOne(dependente => dependente.Socio)
                .WithMany(socio => socio.Dependentes)
                .HasForeignKey("fkSocio");
        }
    }
}
