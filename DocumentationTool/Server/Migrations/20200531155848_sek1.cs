using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class sek1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "DefaultGatewayForNet",
                table: "HostAddresses");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "LicenseKeys",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrinterInputId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrinterOutputId",
                table: "DevicePort",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "Applications",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ServerId",
                table: "People",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseKeys_ServerId",
                table: "LicenseKeys",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ServerId",
                table: "Applications",
                column: "ServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ServerDevices_ServerId",
                table: "Applications",
                column: "ServerId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_ServerDevices_ServerId",
                table: "LicenseKeys",
                column: "ServerId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_ServerDevices_ServerId",
                table: "People",
                column: "ServerId",
                principalTable: "ServerDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ServerDevices_ServerId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_ServerDevices_ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropForeignKey(
                name: "FK_People_ServerDevices_ServerId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ServerId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_LicenseKeys_ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ServerId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropColumn(
                name: "PrinterInputId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "PrinterOutputId",
                table: "DevicePort");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "Applications");

            migrationBuilder.AddColumn<bool>(
                name: "DefaultGatewayForNet",
                table: "HostAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });
        }
    }
}
