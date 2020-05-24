using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cables_Routers_RouterID",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_ServerDevices_ServerID",
                table: "Cables");

            migrationBuilder.DropForeignKey(
                name: "FK_Cables_Switches_SwitchID",
                table: "Cables");

            migrationBuilder.DropIndex(
                name: "IX_Cables_RouterID",
                table: "Cables");

            migrationBuilder.DropIndex(
                name: "IX_Cables_ServerID",
                table: "Cables");

            migrationBuilder.DropIndex(
                name: "IX_Cables_SwitchID",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "RouterID",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "ServerID",
                table: "Cables");

            migrationBuilder.DropColumn(
                name: "SwitchID",
                table: "Cables");

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Switches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "ServerDevices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevicePortId",
                table: "Routers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DevicePort",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Mode = table.Column<string>(nullable: true),
                    Plug = table.Column<string>(nullable: true),
                    Negotiation = table.Column<string>(nullable: true),
                    Duplex = table.Column<string>(nullable: true),
                    Speed = table.Column<int>(nullable: false),
                    SpeedMeasure = table.Column<string>(nullable: true),
                    Mac = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicePort", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecentlyAddeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyAddeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecentlyAddeds_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecentlyUpdateds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyUpdateds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecentlyUpdateds_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortCables",
                columns: table => new
                {
                    PortId = table.Column<int>(nullable: false),
                    CableId = table.Column<int>(nullable: false),
                    DevicePortId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortCables", x => new { x.CableId, x.PortId });
                    table.ForeignKey(
                        name: "FK_PortCables_Cables_CableId",
                        column: x => x.CableId,
                        principalTable: "Cables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortCables_DevicePort_DevicePortId",
                        column: x => x.DevicePortId,
                        principalTable: "DevicePort",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PortCables_DevicePortId",
                table: "PortCables",
                column: "DevicePortId");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyAddeds_GeneralId",
                table: "RecentlyAddeds",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyUpdateds_GeneralId",
                table: "RecentlyUpdateds",
                column: "GeneralId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "ManufacturerNames");

            migrationBuilder.DropTable(
                name: "PortCables");

            migrationBuilder.DropTable(
                name: "RecentlyAddeds");

            migrationBuilder.DropTable(
                name: "RecentlyUpdateds");

            migrationBuilder.DropTable(
                name: "DevicePort");

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
                name: "RouterID",
                table: "Cables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerID",
                table: "Cables",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwitchID",
                table: "Cables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cables_RouterID",
                table: "Cables",
                column: "RouterID",
                unique: true,
                filter: "[RouterID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_ServerID",
                table: "Cables",
                column: "ServerID",
                unique: true,
                filter: "[ServerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_SwitchID",
                table: "Cables",
                column: "SwitchID",
                unique: true,
                filter: "[SwitchID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_Routers_RouterID",
                table: "Cables",
                column: "RouterID",
                principalTable: "Routers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_ServerDevices_ServerID",
                table: "Cables",
                column: "ServerID",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cables_Switches_SwitchID",
                table: "Cables",
                column: "SwitchID",
                principalTable: "Switches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
