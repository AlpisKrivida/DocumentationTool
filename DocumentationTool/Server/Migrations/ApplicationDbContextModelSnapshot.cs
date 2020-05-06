﻿// <auto-generated />
using System;
using DocumentationTool.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocumentationTool.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Contacts.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneCompany")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.BladeChasis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("BladeChases");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPUCores")
                        .HasColumnType("int");

                    b.Property<double>("CPUFrequency")
                        .HasColumnType("float");

                    b.Property<string>("CPUFrequencyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.ClientPC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CPUId")
                        .HasColumnType("int");

                    b.Property<int?>("DesktopId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("HostAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("MemoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CPUId");

                    b.HasIndex("DesktopId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("HostAddressId");

                    b.HasIndex("MemoryId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Desktop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyboardLayout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MouseModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desktops");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.General", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CMDBStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatioDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SYSID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("General");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Memory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapacityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Memory");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firmware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Display")
                        .HasColumnType("float");

                    b.Property<string>("DisplayMeasure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<bool>("Pivot")
                        .HasColumnType("bit");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Speaker")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Mouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mouses");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Printer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Colored")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Duplex")
                        .HasColumnType("bit");

                    b.Property<string>("Emulation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("PaperFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralId");

                    b.HasIndex("ModelId");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.RouterDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<string>("GatewayAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("HostAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.Property<string>("RoutingProtocol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("HostAddressId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("Routers");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.ServerDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CPUId")
                        .HasColumnType("int");

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("MemoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CPUId");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("MemoryId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("ServerDevices");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Switch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("HostAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpanningTree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("HostAddressId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("Switches");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Infrastructure.Cable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CableLenght")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CableLenghtDimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CableType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FibLeads")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<string>("Occupancy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralId");

                    b.ToTable("Cables");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.Access", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccessType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Primary")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accesses");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.FormFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimesnsionUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RackUnit")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<string>("WeightMeasure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("FormFactors");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.HostAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AddressAllocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressStartRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressEndRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DefaultGatewayForNet")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPV4Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetAssignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetMaskEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetMaskStart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Primary")
                        .HasColumnType("bit");

                    b.Property<string>("SearchDomain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HostAddresses");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.PowerConsumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<double>("Ampere")
                        .HasColumnType("float");

                    b.Property<string>("BTU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Volt")
                        .HasColumnType("float");

                    b.Property<double>("Watt")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PowerConsumers");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Contacts.Person", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.BladeChasis", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.FormFactor", "FormFactor")
                        .WithMany()
                        .HasForeignKey("FormFactorId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.ClientPC", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.CPU", "CPU")
                        .WithMany()
                        .HasForeignKey("CPUId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Desktop", "Desktop")
                        .WithMany()
                        .HasForeignKey("DesktopId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.HostAddress", "HostAddress")
                        .WithMany()
                        .HasForeignKey("HostAddressId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Memory", "Memory")
                        .WithMany()
                        .HasForeignKey("MemoryId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Monitor", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.FormFactor", "FormFactor")
                        .WithMany()
                        .HasForeignKey("FormFactorId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Printer", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.RouterDevice", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.FormFactor", "FormFactor")
                        .WithMany()
                        .HasForeignKey("FormFactorId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.HostAddress", "HostAddress")
                        .WithMany()
                        .HasForeignKey("HostAddressId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.ServerDevice", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.CPU", "CPU")
                        .WithMany()
                        .HasForeignKey("CPUId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.FormFactor", "FormFactor")
                        .WithMany()
                        .HasForeignKey("FormFactorId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Memory", "Memory")
                        .WithMany()
                        .HasForeignKey("MemoryId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Switch", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.FormFactor", "FormFactor")
                        .WithMany()
                        .HasForeignKey("FormFactorId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.HostAddress", "HostAddress")
                        .WithMany()
                        .HasForeignKey("HostAddressId");

                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("DocumentationTool.Shared.Entities.Shared.PowerConsumer", "PowerConsumer")
                        .WithMany()
                        .HasForeignKey("PowerConsumerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Infrastructure.Cable", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.General", "General")
                        .WithMany()
                        .HasForeignKey("GeneralId");
                });
#pragma warning restore 612, 618
        }
    }
}
