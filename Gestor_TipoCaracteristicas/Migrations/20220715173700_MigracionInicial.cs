using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor_TipoCaracteristicas.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCaracteristica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCaracteristica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoCaracteristica_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoCaracteristica_ModeloId",
                table: "TipoCaracteristica",
                column: "ModeloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoCaracteristica");

            migrationBuilder.DropTable(
                name: "Modelo");
        }
    }
}
