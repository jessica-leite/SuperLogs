using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperLogs.Api.Migrations
{
    public partial class RemocaoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Log_Usuario_IdUsuario",
                table: "Log");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Log_IdUsuario",
                table: "Log");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Log");

            migrationBuilder.AddColumn<string>(
                name: "TokenUsuario",
                table: "Log",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenUsuario",
                table: "Log");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Log",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Log_IdUsuario",
                table: "Log",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Log_Usuario_IdUsuario",
                table: "Log",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
