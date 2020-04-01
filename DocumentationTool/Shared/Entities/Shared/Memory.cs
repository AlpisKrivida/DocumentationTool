using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class Memory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Manufacture { get; set; }
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string CapacityType { get; set; }
        public string Description { get; set; }
    }
}
