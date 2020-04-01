using DocumentationTool.Shared.Entities.Contacts;
using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BladeChasis> BladeChases { get; set; }
        public DbSet<General> General { get; set; }
        public DbSet<PowerConsumer> PowerConsumers { get; set; }
        public DbSet<FormFactor> FormFactors { get; set; }
        public DbSet<Access> Accesses { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Memory> Memory { get; set; }
        public DbSet<ClientPC> Client { get; set; }
        public DbSet<General> Generals { get; set; }
        public DbSet<HostAddress> HostAddresses { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Router> Routers { get; set; }
        public DbSet<ServerDevice> ServerDevices { get; set; }
        public DbSet<Switch> Switches { get; set; }
    }
}
