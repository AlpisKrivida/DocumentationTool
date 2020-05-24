using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RouterID",
                table: "Cables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerID",
                table: "Cables",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwitchID",
                table: "Cables",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
