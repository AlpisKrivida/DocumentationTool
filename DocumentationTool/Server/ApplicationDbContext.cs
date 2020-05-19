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

namespace DocumentationTool.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optiosn)
            : base(optiosn)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //sample
        //    modelBuilder.Entity<other>().HasKey(x => new { x.other, x.other });
        //    modelBuilder.Entity<other>().HasKey(x => new { x.other, x.other });
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General>().Property(p => p.Tag)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, default),
                    v => JsonSerializer.Deserialize<List<string>>(v, default));

            modelBuilder.Entity<License>()
                .HasMany(x => x.Keys)
                .WithOne();

        }

        //Information
        public DbSet<License> Licenses { get; set; }
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

        //Contacts
        public DbSet<Person> People { get; set; }

        //Infrastructure 
        public DbSet<Cable> Cables { get; set; }
    }
}
