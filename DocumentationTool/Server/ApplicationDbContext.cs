using DocumentationTool.Shared.Entities.Contacts;
using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Infrastructure;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Shared.Entities.Information;
using DocumentationTool.Shared.Entities.Common;
using DocumentationTool.Shared.Entities.Network;

namespace DocumentationTool.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optiosn)
            : base(optiosn)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General>().Property(p => p.Tag)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, default),
                    v => JsonSerializer.Deserialize<List<string>>(v, default));

            //Software
            modelBuilder.Entity<Application>()
                .HasMany<LicenseKey>(x => x.LicenseKeys)
                .WithOne(s => s.Application)
                .HasForeignKey(s => s.ApplicationId);

            //Network
            modelBuilder.Entity<LayerThreeNet>()
                .HasMany(x => x.IpLists)
                .WithOne(s => s.LayerThreeNet)
                .HasForeignKey(s => s.LayerThreeNetId);

            //cables
            modelBuilder.Entity<PortCable>()
                .HasKey(pc => new { pc.CableId, pc.PortId });
                
        }

        //Network
        public DbSet<LayerThreeNet> LayerThreeNets { get; set; }
        public DbSet<IPList> IpLists { get; set; }

        //Software
        public DbSet<Application> Applications { get; set; }
        public DbSet<LicenseKey> LicenseKeys { get; set; }

        //Hardware
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<BladeChasis> BladeChases { get; set; }
        public DbSet<General> General { get; set; }
        public DbSet<PowerConsumer> PowerConsumers { get; set; }
        public DbSet<FormFactor> FormFactors { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Memory> Memory { get; set; }
        public DbSet<ClientPC> Client { get; set; }
        public DbSet<General> Generals { get; set; }
        public DbSet<HostAddress> HostAddresses { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<RouterDevice> Routers { get; set; }
        public DbSet<ServerDevice> ServerDevices { get; set; }
        public DbSet<Switch> Switches { get; set; }
        public DbSet<DevicePort> DevicePort { get; set; }

        //Contacts
        public DbSet<Person> People { get; set; }

        //Infrastructure 
        public DbSet<Cable> Cables { get; set; }

        //Common
        public DbSet<ManufacturerNames> ManufacturerNames {get;set;}
        public DbSet<RecentlyAdded> RecentlyAddeds {get;set;}
        public DbSet<RecentlyUpdated> RecentlyUpdateds {get;set;}

        //Shared
        public DbSet<PortCable> PortCables { get; set; }
    }
}
