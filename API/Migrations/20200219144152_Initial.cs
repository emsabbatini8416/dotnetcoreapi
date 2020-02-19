using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "TipoPermisos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    TipoPermisoId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permisos_TipoPermisos_TipoPermisoId",
                        column: x => x.TipoPermisoId,
                        principalSchema: "dbo",
                        principalTable: "TipoPermisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TipoPermisoId",
                schema: "dbo",
                table: "Permisos",
                column: "TipoPermisoId");


            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TipoPermisos",
                columns: new[] { "Descripcion" },
                values: new object[] { "Enfermadad" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TipoPermisos",
                columns: new[] { "Descripcion" },
                values: new object[] { "Estudio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TipoPermisos",
                schema: "dbo");
        }
    }
}
