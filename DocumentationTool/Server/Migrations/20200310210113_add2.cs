using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Description_DescriptionId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Manufacturer_ManufacturerId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Model_ModelId",
                table: "Monitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_Model_ManufacturerId",
                table: "Models",
                newName: "IX_Models_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_DescriptionId",
                table: "Models",
                newName: "IX_Models_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Description_DescriptionId",
                table: "Models",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Manufacturer_ManufacturerId",
                table: "Models",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Models_ModelId",
                table: "Monitors",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Description_DescriptionId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturer_ManufacturerId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Models_ModelId",
                table: "Monitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameIndex(
                name: "IX_Models_ManufacturerId",
                table: "Model",
                newName: "IX_Model_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_DescriptionId",
                table: "Model",
                newName: "IX_Model_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Description_DescriptionId",
                table: "Model",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Manufacturer_ManufacturerId",
                table: "Model",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Model_ModelId",
                table: "Monitors",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
