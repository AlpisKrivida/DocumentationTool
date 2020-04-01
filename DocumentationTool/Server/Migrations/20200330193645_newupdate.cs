using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_General_Descriptions_DescriptionId",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Descriptions_DescriptionId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturer_ManufacturerId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Descriptions_DescriptionId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Descriptions_DescriptionId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropIndex(
                name: "IX_Persons_DescriptionId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_DescriptionId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Models_DescriptionId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_General_DescriptionId",
                table: "General");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "General");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                newName: "Manufacturers");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Monitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "General",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectID",
                table: "General",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectType",
                table: "General",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SYSID",
                table: "General",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessType = table.Column<string>(nullable: true),
                    Host = table.Column<string>(nullable: true),
                    Primary = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormFactors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RackUnit = table.Column<int>(nullable: false),
                    DimesnsionUnit = table.Column<string>(nullable: true),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    WeightMeasure = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFactors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerConsumers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    PowerModel = table.Column<string>(nullable: true),
                    Volt = table.Column<double>(nullable: false),
                    Watt = table.Column<double>(nullable: false),
                    Ampere = table.Column<double>(nullable: false),
                    BTU = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerConsumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BladeChases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    AccessId = table.Column<int>(nullable: true),
                    FormFactorId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    PowerConsumerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BladeChases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BladeChases_Access_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Access",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_BladeChases_AccessId",
                table: "BladeChases",
                column: "AccessId");

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
                name: "FK_Models_Manufacturers_ManufacturerId",
                table: "Models",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManufacturerId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "BladeChases");

            migrationBuilder.DropTable(
                name: "Access");

            migrationBuilder.DropTable(
                name: "FormFactors");

            migrationBuilder.DropTable(
                name: "PowerConsumers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "General");

            migrationBuilder.DropColumn(
                name: "ObjectID",
                table: "General");

            migrationBuilder.DropColumn(
                name: "ObjectType",
                table: "General");

            migrationBuilder.DropColumn(
                name: "SYSID",
                table: "General");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "Manufacturer");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Monitors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Models",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "General",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DescriptionId",
                table: "Persons",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_DescriptionId",
                table: "Monitors",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_DescriptionId",
                table: "Models",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_General_DescriptionId",
                table: "General",
                column: "DescriptionId");

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
                name: "FK_Models_Manufacturer_ManufacturerId",
                table: "Models",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
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
    }
}
