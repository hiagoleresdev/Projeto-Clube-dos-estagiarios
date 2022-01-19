using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infraestruture.Maps
{
    public class MensalidadeMap : IEntityTypeConfiguration<Mensalidade>
    {
        public void Configure(EntityTypeBuilder<Mensalidade> builder)
        {
            //Especificações da entidade mensalidade
            builder.ToTable("mensalidades");

            builder.HasKey(mensalidade => mensalidade.Id);

            builder.Property(mensalidade => mensalidade.DataVencimento)
                .HasColumnName("vencimento")
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(mensalidade => mensalidade.ValorInicial)
               .HasColumnName("valor-inicial")
               .HasColumnType("FLOAT")
               .IsRequired();

            builder.Property(mensalidade => mensalidade.Juros)
               .HasColumnName("percentual-juros")
               .HasColumnType("INTEGER")
               .HasDefaultValue(8)
               .IsRequired();

            builder.Property(mensalidade => mensalidade.DataPagamento)
               .HasColumnName("data-pagamento")
               .HasColumnType("DATE");

            builder.Property(mensalidade => mensalidade.ValorFinal)
               .HasColumnName("valor-final")
               .HasColumnType("FLOAT");

            builder.Property(mensalidade => mensalidade.Quitada)
               .HasColumnName("quitada")
               .HasColumnType("BIT")
               .IsRequired();

            builder.Property<int>("fkSocio")
               .HasColumnName("fkSocio")
               .HasColumnType("INTEGER")
               .IsRequired();

            builder.HasOne(mensalidade => mensalidade.Socio)
                .WithMany(socio => socio.Mensalidades)
                .HasForeignKey("fkSocio");
        }
    }
}
