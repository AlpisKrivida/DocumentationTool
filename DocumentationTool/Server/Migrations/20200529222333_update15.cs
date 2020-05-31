using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class update15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_ServerId",
                table: "DevicePort",
                column: "ServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerId",
                table: "DevicePort",
                column: "ServerId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_ServerId",
                table: "DevicePort");

            migrationBuilder.AddColumn<int>(
                name: "ServerDeviceId",
                table: "DevicePort",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_ServerDeviceId",
                table: "DevicePort",
                column: "ServerDeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerDeviceId",
                table: "DevicePort",
                column: "ServerDeviceId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
