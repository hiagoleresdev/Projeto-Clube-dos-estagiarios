﻿// <auto-generated />
using System;
using ClubeApi.Infraestruture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubeApi.Migrations
{
    [DbContext(typeof(ClubeDbContext))]
    partial class ClubeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClubeApi.Domain.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Mensalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("DATE")
                        .HasColumnName("data-pagamento");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("DATE")
                        .HasColumnName("vencimento");

                    b.Property<int>("Juros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(8)
                        .HasColumnName("percentual-juros");

                    b.Property<bool>("Quitada")
                        .HasColumnType("BIT")
                        .HasColumnName("quitada");

                    b.Property<double?>("ValorFinal")
                        .HasColumnType("FLOAT")
                        .HasColumnName("valor-final");

                    b.Property<double>("ValorInicial")
                        .HasColumnType("FLOAT")
                        .HasColumnName("valor-inicial");

                    b.Property<int>("fkSocio")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fkSocio");

                    b.HasKey("Id");

                    b.HasIndex("fkSocio");

                    b.ToTable("mensalidades", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("pessoas", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Dependente", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Pessoa");

                    b.Property<decimal>("NumeroCartao")
                        .HasColumnType("NUMERIC(9)")
                        .HasColumnName("cartao");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("parentesco");

                    b.Property<int>("fkSocio")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fkSocio");

                    b.HasIndex("fkSocio");

                    b.ToTable("dependentes", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Funcionario", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Pessoa");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("VARCHAR(32)")
                        .HasColumnName("senha")
                        .HasComputedColumnSql("CONVERT(VARCHAR(32), HashBytes('MD5', '[Senha]'), 2)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(16)")
                        .HasColumnName("usuario");

                    b.ToTable("funcionarios", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Socio", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Pessoa");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("CHAR(8)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)")
                        .HasColumnName("cidade");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("logradouro");

                    b.Property<decimal>("NumeroCartao")
                        .HasColumnType("NUMERIC(9)")
                        .HasColumnName("cartao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("telefone");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("CHAR(2)")
                        .HasColumnName("uf");

                    b.Property<int>("fkCategoria")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fkCategoria");

                    b.HasIndex("fkCategoria");

                    b.ToTable("socios", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Mensalidade", b =>
                {
                    b.HasOne("ClubeApi.Domain.Socio", "Socio")
                        .WithMany("Mensalidades")
                        .HasForeignKey("fkSocio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("ClubeApi.Domain.Dependente", b =>
                {
                    b.HasOne("ClubeApi.Domain.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Dependente", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ClubeApi.Domain.Socio", "Socio")
                        .WithMany("Dependentes")
                        .HasForeignKey("fkSocio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("ClubeApi.Domain.Funcionario", b =>
                {
                    b.HasOne("ClubeApi.Domain.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Funcionario", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClubeApi.Domain.Socio", b =>
                {
                    b.HasOne("ClubeApi.Domain.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Socio", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ClubeApi.Domain.Categoria", "Categoria")
                        .WithMany("Socios")
                        .HasForeignKey("fkCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ClubeApi.Domain.Categoria", b =>
                {
                    b.Navigation("Socios");
                });

            modelBuilder.Entity("ClubeApi.Domain.Socio", b =>
                {
                    b.Navigation("Dependentes");

                    b.Navigation("Mensalidades");
                });
#pragma warning restore 612, 618
        }
    }
}
