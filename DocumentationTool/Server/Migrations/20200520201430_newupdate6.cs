using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_Licenses_LicenseId",
                table: "LicenseKeys");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_LicenseKeys_LicenseId",
                table: "LicenseKeys");

            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "LicenseKeys");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "LicenseKeys",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicenseKeys_ApplicationId",
                table: "LicenseKeys",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_GeneralId",
                table: "Applications",
                column: "GeneralId");

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

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_LicenseKeys_ApplicationId",
                table: "LicenseKeys");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "LicenseKeys");

            migrationBuilder.AddColumn<int>(
                name: "LicenseId",
                table: "LicenseKeys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicenseKeys_LicenseId",
                table: "LicenseKeys",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_GeneralId",
                table: "Licenses",
                column: "GeneralId");

            migrationBuilder.AddForeignKey(
                name: "FK_LicenseKeys_Licenses_LicenseId",
                table: "LicenseKeys",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
