using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "LicenseKeys",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "LicenseKeys",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
