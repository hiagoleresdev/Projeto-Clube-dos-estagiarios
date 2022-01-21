using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infrastructure.Maps
{
    public class SocioMap : IEntityTypeConfiguration<Socio>
    {
        public void Configure(EntityTypeBuilder<Socio> builder)
        {
            //Especificações da entidade Socio
            builder.ToTable("socios");

            builder.Property(socio => socio.NumeroCartao)
                .HasColumnName("cartao")
                .HasColumnType("NUMERIC(9)")
                .IsRequired();

            builder.Property(socio => socio.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("VARCHAR(11)")
                .IsRequired();

            builder.Property(socio => socio.Cep)
                .HasColumnName("cep")
                .HasColumnType("CHAR(8)")
                .IsRequired();
            
            builder.Property(socio => socio.Uf)
                .HasColumnName("uf")
                .HasColumnType("CHAR(2)")
                .IsRequired();

            builder.Property(socio => socio.Cidade)
                .HasColumnName("cidade")
                .HasColumnType("VARCHAR(25)")
                .IsRequired();

            builder.Property(socio => socio.Bairro)
                .HasColumnName("bairro")
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.Property(socio => socio.Logradouro)
                .HasColumnName("logradouro")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.HasOne(socio => socio.Categoria)
                .WithMany(categoria => categoria.Socios)
                .HasForeignKey(socio => socio.FkCategoria)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
