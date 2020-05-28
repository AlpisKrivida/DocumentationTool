using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Routers_RouterId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "RouterId",
                table: "DevicePort");

            migrationBuilder.AddColumn<int>(
                name: "RouterDeviceId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LayerThreeNets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Net = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    NetMask = table.Column<string>(nullable: true),
                    DNSDomain = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayerThreeNets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LayerThreeNets_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IpLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(nullable: true),
                    ServerId = table.Column<int>(nullable: true),
                    RouterId = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    SwitchId = table.Column<int>(nullable: true),
                    PrinterId = table.Column<int>(nullable: true),
                    LayerThreeNetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpLists_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IpLists_LayerThreeNets_LayerThreeNetId",
                        column: x => x.LayerThreeNetId,
                        principalTable: "LayerThreeNets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IpLists_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IpLists_Routers_RouterId",
                        column: x => x.RouterId,
                        principalTable: "Routers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IpLists_ServerDevices_ServerId",
                        column: x => x.ServerId,
                        principalTable: "ServerDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IpLists_Switches_SwitchId",
                        column: x => x.SwitchId,
                        principalTable: "Switches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_RouterDeviceId",
                table: "DevicePort",
                column: "RouterDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_ClientId",
                table: "IpLists",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_LayerThreeNetId",
                table: "IpLists",
                column: "LayerThreeNetId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_PrinterId",
                table: "IpLists",
                column: "PrinterId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_RouterId",
                table: "IpLists",
                column: "RouterId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_ServerId",
                table: "IpLists",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_IpLists_SwitchId",
                table: "IpLists",
                column: "SwitchId");

            migrationBuilder.CreateIndex(
                name: "IX_LayerThreeNets_GeneralId",
                table: "LayerThreeNets",
                column: "GeneralId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Routers_RouterDeviceId",
                table: "DevicePort",
                column: "RouterDeviceId",
                principalTable: "Routers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Routers_RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.DropTable(
                name: "IpLists");

            migrationBuilder.DropTable(
                name: "LayerThreeNets");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "RouterDeviceId",
                table: "DevicePort");

            migrationBuilder.AddColumn<int>(
                name: "RouterId",
                table: "DevicePort",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_RouterId",
                table: "DevicePort",
                column: "RouterId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Routers_RouterId",
                table: "DevicePort",
                column: "RouterId",
                principalTable: "Routers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
