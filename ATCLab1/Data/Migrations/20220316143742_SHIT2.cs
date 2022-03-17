using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATCLab1.Data.Migrations
{
    public partial class SHIT2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Clients_CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Clients_PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_CurrentClientId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_PreviousClientId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CurrentRoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PreviousRoomId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "PreviousClientId",
                table: "Rooms",
                newName: "PreviousRoom");

            migrationBuilder.RenameColumn(
                name: "CurrentClientId",
                table: "Rooms",
                newName: "CurrentRoom");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrentRoom",
                table: "Rooms",
                column: "CurrentRoom",
                unique: true,
                filter: "[CurrentRoom] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PreviousRoom",
                table: "Rooms",
                column: "PreviousRoom",
                unique: true,
                filter: "[PreviousRoom] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_CurrentRoom",
                table: "Rooms",
                column: "CurrentRoom",
                principalTable: "Clients",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_PreviousRoom",
                table: "Rooms",
                column: "PreviousRoom",
                principalTable: "Clients",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Clients_CurrentRoom",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Clients_PreviousRoom",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_CurrentRoom",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_PreviousRoom",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "PreviousRoom",
                table: "Rooms",
                newName: "PreviousClientId");

            migrationBuilder.RenameColumn(
                name: "CurrentRoom",
                table: "Rooms",
                newName: "CurrentClientId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                unique: true,
                filter: "[CurrentClientId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                unique: true,
                filter: "[PreviousClientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                principalTable: "Clients",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                principalTable: "Clients",
                principalColumn: "ID");
        }
    }
}
