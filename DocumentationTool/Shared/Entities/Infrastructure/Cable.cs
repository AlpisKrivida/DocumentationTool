using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Infrastructure
{
    public class Cable
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Color Color { get; set; }
        public string Occupancy { get; set; }
        public string Description { get; set; }
    }
}