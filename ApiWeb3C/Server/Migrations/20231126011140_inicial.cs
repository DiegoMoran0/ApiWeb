using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiWeb3C.Server.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piloto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    POrg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ADebut = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Premios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clasificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fundacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sede = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Premios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Socios = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clasificaciones_Piloto_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Piloto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PaisOrg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NVueltas = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClasificacionId = table.Column<int>(type: "int", nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Clasificaciones_ClasificacionId",
                        column: x => x.ClasificacionId,
                        principalTable: "Clasificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Piloto_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Piloto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clasificaciones_PilotoId",
                table: "Clasificaciones",
                column: "PilotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ClasificacionId",
                table: "Personas",
                column: "ClasificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PilotoId",
                table: "Personas",
                column: "PilotoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Clasificaciones");

            migrationBuilder.DropTable(
                name: "Piloto");
        }
    }
}
