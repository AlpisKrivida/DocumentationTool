using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentationTool.Server.Migrations
{
    public partial class newupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BladeChases_Access_AccessId",
                table: "BladeChases");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Manufacturers_ManufacturerId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Access",
                table: "Access");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Access",
                newName: "Accesses");

            migrationBuilder.AddColumn<int>(
                name: "FormFactorId",
                table: "Monitors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralId",
                table: "Monitors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerConsumerId",
                table: "Monitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Depth",
                table: "FormFactors",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accesses",
                table: "Accesses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CPUCores = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CPUFrequency = table.Column<double>(nullable: false),
                    CPUFrequencyType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Desktops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientType = table.Column<string>(nullable: true),
                    KeyboardLayout = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desktops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HostAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Primary = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    AddressStartRange = table.Column<string>(nullable: true),
                    AdressEndRange = table.Column<string>(nullable: true),
                    NetZone = table.Column<string>(nullable: true),
                    AddressAllocation = table.Column<string>(nullable: true),
                    IPV4Address = table.Column<string>(nullable: true),
                    DefaultGatewayForNet = table.Column<bool>(nullable: false),
                    HostName = table.Column<string>(nullable: true),
                    SearchDomain = table.Column<string>(nullable: true),
                    AssignedPort = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Manufacture = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    CapacityType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    AccessId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Duplex = table.Column<string>(nullable: true),
                    Emulation = table.Column<string>(nullable: true),
                    PaperFormat = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printers_Accesses_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Accesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Printers_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Printers_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Routers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    AccessId = table.Column<int>(nullable: true),
                    HostAddressId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    FormFactorId = table.Column<int>(nullable: true),
                    PowerConsumerId = table.Column<int>(nullable: true),
                    RoutingProtocol = table.Column<string>(nullable: true),
                    GatewayAddress = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routers_Accesses_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Accesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routers_FormFactors_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "FormFactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routers_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routers_HostAddresses_HostAddressId",
                        column: x => x.HostAddressId,
                        principalTable: "HostAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routers_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routers_PowerConsumers_PowerConsumerId",
                        column: x => x.PowerConsumerId,
                        principalTable: "PowerConsumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Switches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    FormFactoryId = table.Column<int>(nullable: true),
                    HostAddressId = table.Column<int>(nullable: true),
                    Vlan = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    SpanningTree = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Switches_FormFactors_FormFactoryId",
                        column: x => x.FormFactoryId,
                        principalTable: "FormFactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Switches_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Switches_HostAddresses_HostAddressId",
                        column: x => x.HostAddressId,
                        principalTable: "HostAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Switches_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenralId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    HostAddressId = table.Column<int>(nullable: true),
                    MemoryId = table.Column<int>(nullable: true),
                    CPUId = table.Column<int>(nullable: true),
                    DesktopId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_CPUs_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Desktops_DesktopId",
                        column: x => x.DesktopId,
                        principalTable: "Desktops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_General_GenralId",
                        column: x => x.GenralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_HostAddresses_HostAddressId",
                        column: x => x.HostAddressId,
                        principalTable: "HostAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Memory_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServerDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralId = table.Column<int>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    FormFactorId = table.Column<int>(nullable: true),
                    AccessId = table.Column<int>(nullable: true),
                    CPUId = table.Column<int>(nullable: true),
                    MemoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerDevices_Accesses_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Accesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerDevices_CPUs_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerDevices_FormFactors_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "FormFactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerDevices_General_GeneralId",
                        column: x => x.GeneralId,
                        principalTable: "General",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerDevices_Memory_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServerDevices_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_FormFactorId",
                table: "Monitors",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_GeneralId",
                table: "Monitors",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_PowerConsumerId",
                table: "Monitors",
                column: "PowerConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CPUId",
                table: "Client",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_DesktopId",
                table: "Client",
                column: "DesktopId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_GenralId",
                table: "Client",
                column: "GenralId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_HostAddressId",
                table: "Client",
                column: "HostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_MemoryId",
                table: "Client",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ModelId",
                table: "Client",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_AccessId",
                table: "Printers",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_GeneralId",
                table: "Printers",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_ModelId",
                table: "Printers",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_AccessId",
                table: "Routers",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_FormFactorId",
                table: "Routers",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_GeneralId",
                table: "Routers",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_HostAddressId",
                table: "Routers",
                column: "HostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_ModelId",
                table: "Routers",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Routers_PowerConsumerId",
                table: "Routers",
                column: "PowerConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_AccessId",
                table: "ServerDevices",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_CPUId",
                table: "ServerDevices",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_FormFactorId",
                table: "ServerDevices",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_GeneralId",
                table: "ServerDevices",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_MemoryId",
                table: "ServerDevices",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerDevices_ModelId",
                table: "ServerDevices",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_FormFactoryId",
                table: "Switches",
                column: "FormFactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_GeneralId",
                table: "Switches",
                column: "GeneralId");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_HostAddressId",
                table: "Switches",
                column: "HostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Switches_ModelId",
                table: "Switches",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_BladeChases_Accesses_AccessId",
                table: "BladeChases",
                column: "AccessId",
                principalTable: "Accesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_FormFactors_FormFactorId",
                table: "Monitors",
                column: "FormFactorId",
                principalTable: "FormFactors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_General_GeneralId",
                table: "Monitors",
                column: "GeneralId",
                principalTable: "General",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_PowerConsumers_PowerConsumerId",
                table: "Monitors",
                column: "PowerConsumerId",
                principalTable: "PowerConsumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BladeChases_Accesses_AccessId",
                table: "BladeChases");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_FormFactors_FormFactorId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_General_GeneralId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_PowerConsumers_PowerConsumerId",
                table: "Monitors");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Routers");

            migrationBuilder.DropTable(
                name: "ServerDevices");

            migrationBuilder.DropTable(
                name: "Switches");

            migrationBuilder.DropTable(
                name: "Desktops");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Memory");

            migrationBuilder.DropTable(
                name: "HostAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_FormFactorId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_GeneralId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_PowerConsumerId",
                table: "Monitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accesses",
                table: "Accesses");

            migrationBuilder.DropColumn(
                name: "FormFactorId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "GeneralId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "PowerConsumerId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Depth",
                table: "FormFactors");

            migrationBuilder.RenameTable(
                name: "Accesses",
                newName: "Access");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Models",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Access",
                table: "Access",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BladeChases_Access_AccessId",
                table: "BladeChases",
                column: "AccessId",
                principalTable: "Access",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Manufacturers_ManufacturerId",
                table: "Models",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
