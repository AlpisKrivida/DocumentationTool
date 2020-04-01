using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class CPU
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CPUCores {get;set;}
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public double CPUFrequency { get; set; }
        public string CPUFrequencyType { get; set; }
        public string Description { get; set; }

    }
}
