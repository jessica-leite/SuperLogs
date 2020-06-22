using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperLogs.Api.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    IdAmbiente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.IdAmbiente);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IdStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "TipoLog",
                columns: table => new
                {
                    IdTipoLog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoLog", x => x.IdTipoLog);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    IdLog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Eventos = table.Column<int>(nullable: false),
                    Host = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    IdStatus = table.Column<int>(nullable: false),
                    IdAmbiente = table.Column<int>(nullable: false),
                    IdTipoLog = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    AmbienteIdAmbiente = table.Column<int>(nullable: true),
                    StatusIdStatus = table.Column<int>(nullable: true),
                    TipoLogIdTipoLog = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.IdLog);
                    table.ForeignKey(
                        name: "FK_Log_Ambiente_AmbienteIdAmbiente",
                        column: x => x.AmbienteIdAmbiente,
                        principalTable: "Ambiente",
                        principalColumn: "IdAmbiente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Log_Status_StatusIdStatus",
                        column: x => x.StatusIdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Log_TipoLog_TipoLogIdTipoLog",
                        column: x => x.TipoLogIdTipoLog,
                        principalTable: "TipoLog",
                        principalColumn: "IdTipoLog",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Log_AmbienteIdAmbiente",
                table: "Log",
                column: "AmbienteIdAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Log_StatusIdStatus",
                table: "Log",
                column: "StatusIdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Log_TipoLogIdTipoLog",
                table: "Log",
                column: "TipoLogIdTipoLog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ambiente");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "TipoLog");
        }
    }
}
