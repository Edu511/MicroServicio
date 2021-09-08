using Microsoft.EntityFrameworkCore.Migrations;

namespace ServicioUsuario.Migrations
{
    public partial class add_tabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosPJEH",
                columns: table => new
                {
                    IDSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOficioSolicitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoAudiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAudiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaAsignada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuzgadoAsignado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsuntoRelacionado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPJEH", x => x.IDSolicitud);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosPJEH");
        }
    }
}
