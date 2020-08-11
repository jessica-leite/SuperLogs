using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperLogs.Api.Migrations
{
    public partial class DadosEstaticos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ambiente",
                columns: new[] { "IdAmbiente", "Tipo" },
                values: new object[,]
                {
                    { 1, "Produção" },
                    { 2, "Homologação" },
                    { 3, "Dev" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "IdStatus", "Tipo" },
                values: new object[,]
                {
                    { 1, "Ativo" },
                    { 2, "Arquivado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ambiente",
                keyColumn: "IdAmbiente",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ambiente",
                keyColumn: "IdAmbiente",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ambiente",
                keyColumn: "IdAmbiente",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "IdStatus",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "IdStatus",
                keyValue: 2);
        }
    }
}
