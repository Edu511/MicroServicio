using Microsoft.EntityFrameworkCore.Migrations;

namespace ServicioPoderJudicial.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBPJ",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_DBPJ", x => x.IdSolicitud);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBPJ");
        }
    }
}
