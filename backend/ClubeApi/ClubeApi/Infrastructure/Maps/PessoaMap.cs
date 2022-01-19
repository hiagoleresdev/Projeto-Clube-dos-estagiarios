using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infrastructure.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            //Especificações da entidade Pessoa
            builder.ToTable("pessoas");

            builder.HasKey(pessoa => pessoa.Id);

            builder.Property(pessoa => pessoa.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(pessoa => pessoa.Email)
               .HasColumnName("email")
               .HasColumnType("VARCHAR(30)")
               .IsRequired();
        }
    }
}
