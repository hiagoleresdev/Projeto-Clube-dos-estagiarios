﻿// <auto-generated />
using System;
using ClubeApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubeApi.Api.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClubeApi.Domain.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Meses")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Meses");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("CATEGORIAS", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Mensalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("DATE")
                        .HasColumnName("DataPagamento");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("DATE")
                        .HasColumnName("Vencimento");

                    b.Property<int>("FkSocio")
                        .HasColumnType("int")
                        .HasColumnName("FkSocio");

                    b.Property<int>("Juros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(8)
                        .HasColumnName("Juros");

                    b.Property<bool>("Quitada")
                        .HasColumnType("BIT")
                        .HasColumnName("Quitada");

                    b.Property<double?>("ValorFinal")
                        .HasColumnType("FLOAT")
                        .HasColumnName("ValorFinal");

                    b.Property<double>("ValorInicial")
                        .HasColumnType("FLOAT")
                        .HasColumnName("ValorInicial");

                    b.HasKey("Id");

                    b.HasIndex("FkSocio");

                    b.ToTable("MENSALIDADES", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("PESSOAS", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Dependente", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Models.Pessoa");

                    b.Property<int>("FkSocio")
                        .HasColumnType("int")
                        .HasColumnName("FkSocio");

                    b.Property<decimal>("NumeroCartao")
                        .HasColumnType("NUMERIC(9)")
                        .HasColumnName("NumeroCartao");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("Parentesco");

                    b.HasIndex("FkSocio");

                    b.ToTable("DEPENDENTES", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Funcionario", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Models.Pessoa");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("VARCHAR(32)")
                        .HasColumnName("senha")
                        .HasComputedColumnSql("CONVERT(VARCHAR(32), HashBytes('MD5', '[Senha]'), 2)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(16)")
                        .HasColumnName("Usuario");

                    b.ToTable("FUNCIONARIOS", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Socio", b =>
                {
                    b.HasBaseType("ClubeApi.Domain.Models.Pessoa");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("CHAR(8)")
                        .HasColumnName("Cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)")
                        .HasColumnName("Cidade");

                    b.Property<int>("FkCategoria")
                        .HasColumnType("int")
                        .HasColumnName("FkCategoria");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("Logradouro");

                    b.Property<decimal>("NumeroCartao")
                        .HasColumnType("NUMERIC(9)")
                        .HasColumnName("NumeroCartao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("Telefone");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("CHAR(2)")
                        .HasColumnName("Uf");

                    b.HasIndex("FkCategoria");

                    b.ToTable("SOCIOS", (string)null);
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Mensalidade", b =>
                {
                    b.HasOne("ClubeApi.Domain.Models.Socio", "Socio")
                        .WithMany("Mensalidades")
                        .HasForeignKey("FkSocio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Dependente", b =>
                {
                    b.HasOne("ClubeApi.Domain.Models.Socio", "Socio")
                        .WithMany("Dependentes")
                        .HasForeignKey("FkSocio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubeApi.Domain.Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Models.Dependente", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Funcionario", b =>
                {
                    b.HasOne("ClubeApi.Domain.Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Models.Funcionario", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Socio", b =>
                {
                    b.HasOne("ClubeApi.Domain.Models.Categoria", "Categoria")
                        .WithMany("Socios")
                        .HasForeignKey("FkCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubeApi.Domain.Models.Pessoa", null)
                        .WithOne()
                        .HasForeignKey("ClubeApi.Domain.Models.Socio", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Categoria", b =>
                {
                    b.Navigation("Socios");
                });

            modelBuilder.Entity("ClubeApi.Domain.Models.Socio", b =>
                {
                    b.Navigation("Dependentes");

                    b.Navigation("Mensalidades");
                });
#pragma warning restore 612, 618
        }
    }
}
