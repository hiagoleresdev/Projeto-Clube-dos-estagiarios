using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubeApi.Infraestruture.Maps
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //Especificações da entidade Pessoa
            builder.ToTable("funcionarios");

            builder.Property(pessoa => pessoa.Usuario)
                .HasColumnName("usuario")
                .HasColumnType("VARCHAR(16)")
                .IsRequired();

            builder.Property(pessoa => pessoa.Senha)
               .HasColumnName("senha")
               .HasColumnType("VARCHAR(32)")
               .HasComputedColumnSql("CONVERT(VARCHAR(32), HashBytes('MD5', '[Senha]'), 2)")
               .IsRequired();
        }
    }
}
