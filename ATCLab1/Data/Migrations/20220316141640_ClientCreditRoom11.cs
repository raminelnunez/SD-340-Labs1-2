using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATCLab1.Data.Migrations
{
    public partial class ClientCreditRoom11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    HolderName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credits_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomNumer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
                    CurrentClientId = table.Column<int>(type: "int", nullable: false),
                    PreviousClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomNumer);
                    table.ForeignKey(
                        name: "FK_Rooms_Clients_CurrentClientId",
                        column: x => x.CurrentClientId,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_Clients_PreviousClientId",
                        column: x => x.PreviousClientId,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Credits_ClientID",
                table: "Credits",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
