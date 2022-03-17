using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATCLab1.Data.Migrations
{
    public partial class ClientCreditRoom21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentRoomId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousRoomId",
                table: "Clients",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Clients");
        }
    }
}
