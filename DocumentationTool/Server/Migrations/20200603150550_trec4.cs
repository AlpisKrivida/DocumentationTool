using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class trec4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Broadcast",
                table: "LayerThreeNets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndHost",
                table: "LayerThreeNets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartHost",
                table: "LayerThreeNets",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "General",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Broadcast",
                table: "LayerThreeNets");

            migrationBuilder.DropColumn(
                name: "EndHost",
                table: "LayerThreeNets");

            migrationBuilder.DropColumn(
                name: "StartHost",
                table: "LayerThreeNets");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "General",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
