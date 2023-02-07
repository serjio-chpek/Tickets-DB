using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp21.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passangers",
                columns: table => new
                {
                    IdPassanger = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passangers", x => x.IdPassanger);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    IdPoint = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.IdPoint);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    IdTicket = table.Column<Guid>(type: "TEXT", nullable: false),
                    PassangerIdPassanger = table.Column<int>(type: "INTEGER", nullable: false),
                    PointDepartureIdPoint = table.Column<int>(type: "INTEGER", nullable: false),
                    PointArrivalIdPoint = table.Column<int>(type: "INTEGER", nullable: false),
                    DateArrive = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.IdTicket);
                    table.ForeignKey(
                        name: "FK_Tickets_Passangers_PassangerIdPassanger",
                        column: x => x.PassangerIdPassanger,
                        principalTable: "Passangers",
                        principalColumn: "IdPassanger",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Points_PointArrivalIdPoint",
                        column: x => x.PointArrivalIdPoint,
                        principalTable: "Points",
                        principalColumn: "IdPoint",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Points_PointDepartureIdPoint",
                        column: x => x.PointDepartureIdPoint,
                        principalTable: "Points",
                        principalColumn: "IdPoint",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassangerIdPassanger",
                table: "Tickets",
                column: "PassangerIdPassanger");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PointArrivalIdPoint",
                table: "Tickets",
                column: "PointArrivalIdPoint");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PointDepartureIdPoint",
                table: "Tickets",
                column: "PointDepartureIdPoint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Passangers");

            migrationBuilder.DropTable(
                name: "Points");
        }
    }
}
