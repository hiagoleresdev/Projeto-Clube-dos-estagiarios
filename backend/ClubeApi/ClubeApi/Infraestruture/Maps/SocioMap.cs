using ClubeApi.Domain;
using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infraestruture.Maps
{
    public class SocioMap : IEntityTypeConfiguration<Socio>
    {
        public void Configure(EntityTypeBuilder<Socio> builder)
        {
            builder.ToTable("socio");

            builder.HasKey(socio => socio.Id);

            builder.Property(socio => socio.Id)
                .HasColumnName("idSocio")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(pessoa => pessoa.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(pessoa => pessoa.NumeroCartao)
                .HasColumnName("numeroCartao")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(pessoa => pessoa.Parentesco)
                .HasColumnName("parentesco")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(pessoa => pessoa.Email)
               .HasColumnName("email")
               .HasColumnType("VARCHAR(30)")
               .IsRequired();

        }
    }
}
