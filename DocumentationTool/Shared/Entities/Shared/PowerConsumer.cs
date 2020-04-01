using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class PowerConsumer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public string Manufacturer { get; set;}
        public string PowerModel { get; set; }
        public double Volt { get; set; }
        public double Watt { get; set; }
        public double Ampere { get; set; }
        public string BTU { get; set; }
        public string Description { get; set; }
    }
}
