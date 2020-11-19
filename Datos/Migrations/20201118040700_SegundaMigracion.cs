using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Personas_PersonaNumeroDeDocumento",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "PersonaNumeroDeDocumento",
                table: "Pagos",
                newName: "personaNumeroDeDocumento");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_PersonaNumeroDeDocumento",
                table: "Pagos",
                newName: "IX_Pagos_personaNumeroDeDocumento");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Personas_personaNumeroDeDocumento",
                table: "Pagos",
                column: "personaNumeroDeDocumento",
                principalTable: "Personas",
                principalColumn: "NumeroDeDocumento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Personas_personaNumeroDeDocumento",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "personaNumeroDeDocumento",
                table: "Pagos",
                newName: "PersonaNumeroDeDocumento");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_personaNumeroDeDocumento",
                table: "Pagos",
                newName: "IX_Pagos_PersonaNumeroDeDocumento");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Personas_PersonaNumeroDeDocumento",
                table: "Pagos",
                column: "PersonaNumeroDeDocumento",
                principalTable: "Personas",
                principalColumn: "NumeroDeDocumento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
