using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubeApi.Migrations
{
    public partial class UsandoPOG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCategoria",
                table: "socios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSocio",
                table: "mensalidades",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSocio",
                table: "dependentes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idCategoria",
                table: "socios");

            migrationBuilder.DropColumn(
                name: "idSocio",
                table: "mensalidades");

            migrationBuilder.DropColumn(
                name: "idSocio",
                table: "dependentes");
        }
    }
}
