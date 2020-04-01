using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    CMDBStatus = table.Column<string>(nullable: true),
                    CreatioDate = table.Column<DateTime>(nullable: false),
                    DateOfChange = table.Column<DateTime>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Id);
                    table.ForeignKey(
                        name: "FK_General_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicDegree = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true),
                    ServiceDesignation = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZIPCode = table.Column<string>(nullable: true),
                    EMailAdress = table.Column<string>(nullable: true),
                    TelephoneCompany = table.Column<string>(nullable: true),
                    TelephoneHome = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Pager = table.Column<string>(nullable: true),
                    PersonalNumber = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Organisation = table.Column<string>(nullable: true),
                    DescriptionId = table.Column<int>(nullable: true),
                    GeneralId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_General_DescriptionId",
                table: "General",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DescriptionId",
                table: "Persons",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GeneralId",
                table: "Persons",
                column: "GeneralId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "General");
        }
    }
}
