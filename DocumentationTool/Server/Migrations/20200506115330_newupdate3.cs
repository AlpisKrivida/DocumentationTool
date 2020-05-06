using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BladeChases_Accesses_AccessId",
                table: "BladeChases");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_General_GenralId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_General_GeneralId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_Accesses_AccessId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_Routers_Accesses_AccessId",
                table: "Routers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerDevices_Accesses_AccessId",
                table: "ServerDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_Switches_FormFactors_FormFactoryId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_Switches_FormFactoryId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_ServerDevices_AccessId",
                table: "ServerDevices");

            migrationBuilder.DropIndex(
                name: "IX_Routers_AccessId",
                table: "Routers");

            migrationBuilder.DropIndex(
                name: "IX_Printers_AccessId",
                table: "Printers");

            migrationBuilder.DropIndex(
                name: "IX_Client_GenralId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_BladeChases_AccessId",
                table: "BladeChases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "FormFactoryId",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "AccessId",
                table: "ServerDevices");

            migrationBuilder.DropColumn(
                name: "AccessId",
                table: "Routers");

            migrationBuilder.DropColumn(
                name: "AccessId",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "ClientType",
                table: "Desktops");

            migrationBuilder.DropColumn(
                name: "GenralId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AccessId",
                table: "BladeChases");

            migrationBuilder.DropColumn(
                name: "AcademicDegree",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Organisation",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Pager",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ServiceDesignation",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TelephoneHome",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ZIPCode",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "People");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_GeneralId",
                table: "People",
                newName: "IX_People_GeneralId");

            migrationBuilder.AddColumn<int>(
                name: "FormFactorId",
                table: "Switches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerConsumerId",
                table: "Switches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerConsumerId",
                table: "ServerDevices",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Duplex",
                table: "Printers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Colored",
                table: "Printers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NetAssignment",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetMaskEnd",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetMaskStart",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "HostAddresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Desktops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MouseModel",
                table: "Desktops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Desktops",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralId",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerConsumerId",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Accesses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "People",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    CableType = table.Column<string>(nullable: true),
                    CableLenght = table.Column<string>(nullable: true),
                    CableLenghtDimensions = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Occupancy = table.Column<string>(nullable: true),
                    FibLeads = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cables_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Switches_FormFactorId",
                table: "Switches",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_PowerConsumerId",
                table: "Switches",
                column: "PowerConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_PowerConsumerId",
                table: "ServerDevices",
                column: "PowerConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_GeneralId",
                table: "Client",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_PowerConsumerId",
                table: "Client",
                column: "PowerConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_GeneralId",
                table: "Cables",
                column: "GeneralId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_General_GeneralId",
                table: "Client",
                column: "GeneralId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_PowerConsumers_PowerConsumerId",
                table: "Client",
                column: "PowerConsumerId",
                principalTable: "PowerConsumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_General_GeneralId",
                table: "People",
                column: "GeneralId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerDevices_PowerConsumers_PowerConsumerId",
                table: "ServerDevices",
                column: "PowerConsumerId",
                principalTable: "PowerConsumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_FormFactors_FormFactorId",
                table: "Switches",
                column: "FormFactorId",
                principalTable: "FormFactors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_PowerConsumers_PowerConsumerId",
                table: "Switches",
                column: "PowerConsumerId",
                principalTable: "PowerConsumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_General_GeneralId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_PowerConsumers_PowerConsumerId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_People_General_GeneralId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerDevices_PowerConsumers_PowerConsumerId",
                table: "ServerDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_Switches_FormFactors_FormFactorId",
                table: "Switches");

            migrationBuilder.DropForeignKey(
                name: "FK_Switches_PowerConsumers_PowerConsumerId",
                table: "Switches");

            migrationBuilder.DropTable(
                name: "Cables");

            migrationBuilder.DropIndex(
                name: "IX_Switches_FormFactorId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_Switches_PowerConsumerId",
                table: "Switches");

            migrationBuilder.DropIndex(
                name: "IX_ServerDevices_PowerConsumerId",
                table: "ServerDevices");

            migrationBuilder.DropIndex(
                name: "IX_Client_GeneralId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_PowerConsumerId",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "FormFactorId",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "PowerConsumerId",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "PowerConsumerId",
                table: "ServerDevices");

            migrationBuilder.DropColumn(
                name: "Colored",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "NetAssignment",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetMaskEnd",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "NetMaskStart",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "HostAddresses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Desktops");

            migrationBuilder.DropColumn(
                name: "MouseModel",
                table: "Desktops");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Desktops");

            migrationBuilder.DropColumn(
                name: "GeneralId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PowerConsumerId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Accesses");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_People_GeneralId",
                table: "Persons",
                newName: "IX_Persons_GeneralId");

            migrationBuilder.AddColumn<int>(
                name: "FormFactoryId",
                table: "Switches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessId",
                table: "ServerDevices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessId",
                table: "Routers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duplex",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "AccessId",
                table: "Printers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientType",
                table: "Desktops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenralId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessId",
                table: "BladeChases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcademicDegree",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Organisation",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pager",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceDesignation",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneHome",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZIPCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_FormFactoryId",
                table: "Switches",
                column: "FormFactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_AccessId",
                table: "ServerDevices",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_AccessId",
                table: "Routers",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_AccessId",
                table: "Printers",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_GenralId",
                table: "Client",
                column: "GenralId");

            migrationBuilder.CreateIndex(
                name: "IX_BladeChases_AccessId",
                table: "BladeChases",
                column: "AccessId");

            migrationBuilder.AddForeignKey(
                name: "FK_BladeChases_Accesses_AccessId",
                table: "BladeChases",
                column: "AccessId",
                principalTable: "Accesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_General_GenralId",
                table: "Client",
                column: "GenralId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_General_GeneralId",
                table: "Persons",
                column: "GeneralId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_Accesses_AccessId",
                table: "Printers",
                column: "AccessId",
                principalTable: "Accesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Routers_Accesses_AccessId",
                table: "Routers",
                column: "AccessId",
                principalTable: "Accesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerDevices_Accesses_AccessId",
                table: "ServerDevices",
                column: "AccessId",
                principalTable: "Accesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_FormFactors_FormFactoryId",
                table: "Switches",
                column: "FormFactoryId",
                principalTable: "FormFactors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
