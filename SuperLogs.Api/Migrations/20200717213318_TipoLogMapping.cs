using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperLogs.Api.Migrations
{
    public partial class TipoLogMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoLog",
                columns: new[] { "IdTipoLog", "Tipo" },
                values: new object[] { 1, "Debug" });

            migrationBuilder.InsertData(
                table: "TipoLog",
                columns: new[] { "IdTipoLog", "Tipo" },
                values: new object[] { 2, "Warning" });

            migrationBuilder.InsertData(
                table: "TipoLog",
                columns: new[] { "IdTipoLog", "Tipo" },
                values: new object[] { 3, "Error" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoLog",
                keyColumn: "IdTipoLog",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoLog",
                keyColumn: "IdTipoLog",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoLog",
                keyColumn: "IdTipoLog",
                keyValue: 3);
        }
    }
}
