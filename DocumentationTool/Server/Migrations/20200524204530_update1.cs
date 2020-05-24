using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DevicePort_DevicePortId",
                table: "Cables");

            migrationBuilder.DropIndex(
                name: "IX_Cables_DevicePortId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "DevicePortId",
                table: "Cables");

            migrationBuilder.AddColumn<int>(
                name: "RouterInpuId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RouterOutputd",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerInpuId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerOutputId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwitchInputId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwitchOutputId",
                table: "DevicePort",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouterInpuId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "RouterOutputd",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerInpuId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerOutputId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "SwitchInputId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "SwitchOutputId",
                table: "DevicePort");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "DevicePort",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Cables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cables_DevicePortId",
                table: "Cables",
                column: "DevicePortId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_DevicePort_DevicePortId",
                table: "Cables",
                column: "DevicePortId",
                principalTable: "DevicePort",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
