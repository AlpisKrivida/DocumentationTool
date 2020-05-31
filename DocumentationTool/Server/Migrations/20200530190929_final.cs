using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Routers_RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.DropTable(
                name: "Mouses");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "AddressStartRange",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "AdressEndRange",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "AssignedPort",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "IPV4Address",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetAssignment",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetMaskEnd",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetMaskStart",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetZone",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "Primary",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "SearchDomain",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.AddColumn<int>(
                name: "HostAddressId",
                table: "ServerDevices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HostAddressId",
                table: "Printers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NetAssignmentId",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrinterId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RouterId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_HostAddressId",
                table: "ServerDevices",
                column: "HostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_HostAddressId",
                table: "Printers",
                column: "HostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_HostAddresses_AddressId",
                table: "HostAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_HostAddresses_NetAssignmentId",
                table: "HostAddresses",
                column: "NetAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_PrinterId",
                table: "DevicePort",
                column: "PrinterId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort",
                column: "RouterId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Printers_PrinterId",
                table: "DevicePort",
                column: "PrinterId",
                principalTable: "Printers",
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
                name: "FK_HostAddresses_IpLists_AddressId",
                table: "HostAddresses",
                column: "AddressId",
                principalTable: "IpLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostAddresses_LayerThreeNets_NetAssignmentId",
                table: "HostAddresses",
                column: "NetAssignmentId",
                principalTable: "LayerThreeNets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_HostAddresses_HostAddressId",
                table: "Printers",
                column: "HostAddressId",
                principalTable: "HostAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerDevices_HostAddresses_HostAddressId",
                table: "ServerDevices",
                column: "HostAddressId",
                principalTable: "HostAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Printers_PrinterId",
                table: "DevicePort");

            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Routers_RouterId",
                table: "DevicePort");

            migrationBuilder.DropForeignKey(
                name: "FK_HostAddresses_IpLists_AddressId",
                table: "HostAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_HostAddresses_LayerThreeNets_NetAssignmentId",
                table: "HostAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_HostAddresses_HostAddressId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerDevices_HostAddresses_HostAddressId",
                table: "ServerDevices");

            migrationBuilder.DropIndex(
                name: "IX_ServerDevices_HostAddressId",
                table: "ServerDevices");

            migrationBuilder.DropIndex(
                name: "IX_Printers_HostAddressId",
                table: "Printers");

            migrationBuilder.DropIndex(
                name: "IX_HostAddresses_AddressId",
                table: "HostAddresses");

            migrationBuilder.DropIndex(
                name: "IX_HostAddresses_NetAssignmentId",
                table: "HostAddresses");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_PrinterId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "HostAddressId",
                table: "ServerDevices");

            migrationBuilder.DropColumn(
                name: "HostAddressId",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetAssignmentId",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "PrinterId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "RouterId",
                table: "DevicePort");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "HostAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AddressStartRange",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdressEndRange",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedPort",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPV4Address",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetAssignment",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetMaskEnd",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetMaskStart",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetZone",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Primary",
                table: "HostAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SearchDomain",
                table: "HostAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RouterDeviceId",
                table: "DevicePort",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mouses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_RouterDeviceId",
                table: "DevicePort",
                column: "RouterDeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Routers_RouterDeviceId",
                table: "DevicePort",
                column: "RouterDeviceId",
                principalTable: "Routers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
