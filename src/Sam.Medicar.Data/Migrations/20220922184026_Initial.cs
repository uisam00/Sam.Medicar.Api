using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sam.Medicar.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CRM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    IdEspecialidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    Horarios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAgenda = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consulta_Agenda_IdAgenda",
                        column: x => x.IdAgenda,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Especialidade",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Pediatria" },
                    { 2, "Ginecologia" },
                    { 3, "Cardiologia" },
                    { 4, "Clínico Geral" }
                });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "Id", "CRM", "Email", "IdEspecialidade", "Nome" },
                values: new object[,]
                {
                    { 1, "3711", "drauzinho@medicar.com.br", 1, "Drauzio Varella" },
                    { 2, "2544", "gregory@medicar.com.br", 2, "Gregory House" },
                    { 3, "2227", "medicones@medicar.com.br", 3, "Medicones Doutoris" },
                    { 4, "4367", "lauro@medicar.com.br", 4, "Lauro Cirurgis" }
                });

            migrationBuilder.InsertData(
                table: "Agenda",
                columns: new[] { "Id", "Dia", "Horarios", "IdMedico" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 1 },
                    { 2, new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 1 },
                    { 3, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 2 },
                    { 4, new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 2 },
                    { 5, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 3 },
                    { 6, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 3 },
                    { 7, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 4 },
                    { 8, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "09:00,10:00,13:30,15:00", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_IdMedico",
                table: "Agenda",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdAgenda",
                table: "Consulta",
                column: "IdAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdEspecialidade",
                table: "Medico",
                column: "IdEspecialidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Especialidade");
        }
    }
}
