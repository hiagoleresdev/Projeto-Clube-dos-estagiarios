using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubeApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "socio",
                columns: table => new
                {
                    idSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    numeroCartao = table.Column<int>(type: "INTEGER", nullable: false),
                    parentesco = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    email = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socio", x => x.idSocio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "socio");
        }
    }
}
