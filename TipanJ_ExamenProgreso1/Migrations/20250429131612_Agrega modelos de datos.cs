using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipanJ_ExamenProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class Agregamodelosdedatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recompensa",
                columns: table => new
                {
                    IdRecompensa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuntosAcumulados = table.Column<int>(type: "int", nullable: false),
                    TipoDeRecompensa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recompensa", x => x.IdRecompensa);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valorPagar = table.Column<bool>(type: "bit", nullable: false),
                    InformacionCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRecompensa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Recompensa_IdRecompensa",
                        column: x => x.IdRecompensa,
                        principalTable: "Recompensa",
                        principalColumn: "IdRecompensa");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", maxLength: 8, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiasHospedaje = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", maxLength: 4, nullable: false),
                    PuntuacionServicio = table.Column<float>(type: "real", nullable: false),
                    DescuentorPorRecomendacion = table.Column<bool>(type: "bit", nullable: false),
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Reserva_IdReserva",
                        column: x => x.IdReserva,
                        principalTable: "Reserva",
                        principalColumn: "IdReserva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdReserva",
                table: "Cliente",
                column: "IdReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IdRecompensa",
                table: "Reserva",
                column: "IdRecompensa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Recompensa");
        }
    }
}
