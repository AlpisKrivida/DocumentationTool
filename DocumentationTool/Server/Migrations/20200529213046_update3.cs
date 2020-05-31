using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortCables");

            migrationBuilder.AddColumn<int>(
                name: "CableId",
                table: "DevicePort",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DevicePort_CableId",
                table: "DevicePort",
                column: "CableId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort",
                column: "CableId",
                principalTable: "Cables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevicePort_Cables_CableId",
                table: "DevicePort");

            migrationBuilder.DropIndex(
                name: "IX_DevicePort_CableId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "CableId",
                table: "DevicePort");

            migrationBuilder.CreateTable(
                name: "PortCables",
                columns: table => new
                {
                    CableId = table.Column<int>(type: "int", nullable: false),
                    PortId = table.Column<int>(type: "int", nullable: false),
                    DevicePortId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_PortCables_DevicePortId",
                table: "PortCables",
                column: "DevicePortId");
        }
    }
}
