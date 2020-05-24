using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "LicenseKeys",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_Applications_ApplicationId",
                table: "LicenseKeys",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
