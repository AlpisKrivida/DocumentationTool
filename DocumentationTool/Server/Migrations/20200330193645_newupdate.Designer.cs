﻿// <auto-generated />
using System;
using DocumentationTool.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocumentationTool.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200330193645_newupdate")]
    partial class newupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AcademicDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.BladeChasis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccessId")
                        .HasColumnType("int");

                    b.Property<int?>("FormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int?>("PowerConsumerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessId");

                    b.HasIndex("FormFactorId");

                    b.HasIndex("GeneralId");

                    b.HasIndex("ModelId");

                    b.HasIndex("PowerConsumerId");

                    b.ToTable("BladeChases");
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

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

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

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<bool>("Pivot")
                        .HasColumnType("bit");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Speaker")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

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

                    b.HasKey("Id");

                    b.ToTable("Access");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Shared.FormFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.Access", "Access")
                        .WithMany()
                        .HasForeignKey("AccessId");

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

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Model", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Shared.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");
                });

            modelBuilder.Entity("DocumentationTool.Shared.Entities.Hardware.Monitor", b =>
                {
                    b.HasOne("DocumentationTool.Shared.Entities.Hardware.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
