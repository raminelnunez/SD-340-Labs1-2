using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATCLab1.Data.Migrations
{
    public partial class ClientCreditRoom20 : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "PreviousClientId",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentClientId",
                table: "Rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PreviousClientId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentClientId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_CurrentClientId",
                table: "Rooms",
                column: "CurrentClientId",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Clients_PreviousClientId",
                table: "Rooms",
                column: "PreviousClientId",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
