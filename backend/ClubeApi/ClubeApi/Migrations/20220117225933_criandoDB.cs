using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubeApi.Migrations
{
    public partial class criandoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    email = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    usuario = table.Column<string>(type: "VARCHAR(16)", nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(32)", nullable: false, computedColumnSql: "CONVERT(VARCHAR(32), HashBytes('MD5', '[Senha]'), 2)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_funcionarios_pessoas_Id",
                        column: x => x.Id,
                        principalTable: "pessoas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "socios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cartao = table.Column<decimal>(type: "NUMERIC(9)", nullable: false),
                    telefone = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    cep = table.Column<string>(type: "CHAR(8)", nullable: false),
                    uf = table.Column<string>(type: "CHAR(2)", nullable: false),
                    cidade = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    bairro = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    logradouro = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    fkCategoria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_socios_Categorias_fkCategoria",
                        column: x => x.fkCategoria,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_socios_pessoas_Id",
                        column: x => x.Id,
                        principalTable: "pessoas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "dependentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    cartao = table.Column<decimal>(type: "NUMERIC(9)", nullable: false),
                    parentesco = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    fkSocio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dependentes_pessoas_Id",
                        column: x => x.Id,
                        principalTable: "pessoas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dependentes_socios_fkSocio",
                        column: x => x.fkSocio,
                        principalTable: "socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mensalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vencimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    valorinicial = table.Column<double>(name: "valor-inicial", type: "FLOAT", nullable: false),
                    datapagamento = table.Column<DateTime>(name: "data-pagamento", type: "DATE", nullable: true),
                    percentualjuros = table.Column<int>(name: "percentual-juros", type: "INTEGER", nullable: false, defaultValue: 8),
                    valorfinal = table.Column<double>(name: "valor-final", type: "FLOAT", nullable: true),
                    quitada = table.Column<bool>(type: "BIT", nullable: false),
                    fkSocio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mensalidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mensalidades_socios_fkSocio",
                        column: x => x.fkSocio,
                        principalTable: "socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dependentes_fkSocio",
                table: "dependentes",
                column: "fkSocio");

            migrationBuilder.CreateIndex(
                name: "IX_mensalidades_fkSocio",
                table: "mensalidades",
                column: "fkSocio");

            migrationBuilder.CreateIndex(
                name: "IX_socios_fkCategoria",
                table: "socios",
                column: "fkCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dependentes");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "mensalidades");

            migrationBuilder.DropTable(
                name: "socios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "pessoas");
        }
    }
}
