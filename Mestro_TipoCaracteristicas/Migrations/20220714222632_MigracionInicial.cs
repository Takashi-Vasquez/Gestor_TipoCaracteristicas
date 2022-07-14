using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maestro_TipoCaracteristicas.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoCaracteristica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCaracteristica", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoCaracteristica",
                columns: new[] { "Id", "Abreviatura", "Equipo" },
                values: new object[] { 1, "msinha", "Mouse Inhalambrico" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoCaracteristica");
        }
    }
}
