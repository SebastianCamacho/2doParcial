using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class primeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    NumeroDeDocumento = table.Column<string>(nullable: false),
                    TipoDeDocumento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.NumeroDeDocumento);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdDePago = table.Column<string>(nullable: false),
                    TipoDePago = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    ValorDePago = table.Column<decimal>(nullable: false),
                    ValorIva = table.Column<decimal>(nullable: false),
                    PersonaNumeroDeDocumento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdDePago);
                    table.ForeignKey(
                        name: "FK_Pagos_Personas_PersonaNumeroDeDocumento",
                        column: x => x.PersonaNumeroDeDocumento,
                        principalTable: "Personas",
                        principalColumn: "NumeroDeDocumento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PersonaNumeroDeDocumento",
                table: "Pagos",
                column: "PersonaNumeroDeDocumento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
