using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class general : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_Description_DescriptionId",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Description_DescriptionId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Description_DescriptionId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Description_DescriptionId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Description",
                table: "Description");

            migrationBuilder.RenameTable(
                name: "Description",
                newName: "Descriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_General_Descriptions_DescriptionId",
                table: "General",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Descriptions_DescriptionId",
                table: "Models",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Descriptions_DescriptionId",
                table: "Monitors",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Descriptions_DescriptionId",
                table: "Persons",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_Descriptions_DescriptionId",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Descriptions_DescriptionId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Descriptions_DescriptionId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Descriptions_DescriptionId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions");

            migrationBuilder.RenameTable(
                name: "Descriptions",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Description",
                table: "Description",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_General_Description_DescriptionId",
                table: "General",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Description_DescriptionId",
                table: "Models",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Description_DescriptionId",
                table: "Monitors",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Description_DescriptionId",
                table: "Persons",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
