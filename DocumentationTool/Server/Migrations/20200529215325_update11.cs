using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class update11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort");

            migrationBuilder.AlterColumn<int>(
                name: "CableId",
                table: "DevicePort",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort",
                column: "CableId",
                principalTable: "Cables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort");

            migrationBuilder.AlterColumn<int>(
                name: "CableId",
                table: "DevicePort",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort",
                column: "CableId",
                principalTable: "Cables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
