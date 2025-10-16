using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CiudadanosServicesCS.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ciudadanos");

            migrationBuilder.CreateTable(
                name: "TB_NombresPropios",
                schema: "Ciudadanos",
                columns: table => new
                {
                    PkiNombrePropio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FcNombrePropio = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    FdFechaCreacion = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    FiUsuarioCreacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NombresPropios", x => x.PkiNombrePropio);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_NombresPropios",
                schema: "Ciudadanos");
        }
    }
}
