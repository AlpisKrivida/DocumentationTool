using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routers_DevicePort_DevicePortId",
                table: "Routers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerDevices_DevicePort_DevicePortId",
                table: "ServerDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_Switches_DevicePort_DevicePortId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_Switches_DevicePortId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_ServerDevices_DevicePortId",
                table: "ServerDevices");

            migrationBuilder.DropIndex(
                name: "IX_Routers_DevicePortId",
                table: "Routers");

            migrationBuilder.DropColumn(
                name: "DevicePortId",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "DevicePortId",
                table: "ServerDevices");

            migrationBuilder.DropColumn(
                name: "DevicePortId",
                table: "Routers");

            migrationBuilder.AddColumn<int>(
                name: "RouterId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerDeviceId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwitchId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Cables",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort",
                column: "RouterId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_ServerDeviceId",
                table: "DevicePort",
                column: "ServerDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_SwitchId",
                table: "DevicePort",
                column: "SwitchId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Routers_RouterId",
                table: "DevicePort",
                column: "RouterId",
                principalTable: "Routers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerDeviceId",
                table: "DevicePort",
                column: "ServerDeviceId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Switches_SwitchId",
                table: "DevicePort",
                column: "SwitchId",
                principalTable: "Switches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_DevicePort_DevicePortId",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Routers_RouterId",
                table: "DevicePort");

            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_ServerDevices_ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Switches_SwitchId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_SwitchId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_Cables_DevicePortId",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "RouterId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerDeviceId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "SwitchId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "DevicePortId",
                table: "Cables");

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Switches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "ServerDevices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Routers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Switches_DevicePortId",
                table: "Switches",
                column: "DevicePortId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_DevicePortId",
                table: "ServerDevices",
                column: "DevicePortId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_DevicePortId",
                table: "Routers",
                column: "DevicePortId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routers_DevicePort_DevicePortId",
                table: "Routers",
                column: "DevicePortId",
                principalTable: "DevicePort",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerDevices_DevicePort_DevicePortId",
                table: "ServerDevices",
                column: "DevicePortId",
                principalTable: "DevicePort",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_DevicePort_DevicePortId",
                table: "Switches",
                column: "DevicePortId",
                principalTable: "DevicePort",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
