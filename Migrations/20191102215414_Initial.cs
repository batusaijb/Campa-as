using Microsoft.EntityFrameworkCore.Migrations;

namespace Campañas.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaña",
                columns: table => new
                {
                    IdCamapana = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<string>(nullable: true),
                    FechaFin = table.Column<string>(nullable: true),
                    UsuarioCreador = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<string>(nullable: true),
                    RutaBanner = table.Column<string>(nullable: true),
                    IdProducto = table.Column<int>(nullable: true),
                    nombreProducto = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaña", x => x.IdCamapana);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaña");
        }
    }
}
