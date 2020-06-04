using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class ket2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ServerDevices_ServerId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_LicenseKeys_ServerDevices_ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropTable(
                name: "BladeChases");

            migrationBuilder.DropIndex(
                name: "IX_LicenseKeys_ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ServerId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "LicenseKeys");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "Applications");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "LicenseKeys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BladeChases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFactorId = table.Column<int>(type: "int", nullable: true),
                    GeneralId = table.Column<int>(type: "int", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: true),
                    PowerConsumerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BladeChases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BladeChases_FormFactors_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "FormFactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BladeChases_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BladeChases_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BladeChases_PowerConsumers_PowerConsumerId",
                        column: x => x.PowerConsumerId,
                        principalTable: "PowerConsumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicenseKeys_ServerId",
                table: "LicenseKeys",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ServerId",
                table: "Applications",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_BladeChases_FormFactorId",
                table: "BladeChases",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_BladeChases_GeneralId",
                table: "BladeChases",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_BladeChases_ModelId",
                table: "BladeChases",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BladeChases_PowerConsumerId",
                table: "BladeChases",
                column: "PowerConsumerId");

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
        }
    }
}
