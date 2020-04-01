using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class Printer
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Model Model { get; set; }
        public Access Access { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Duplex { get; set; }
        public string Emulation { get; set; }
        public string PaperFormat { get; set; }
        public string Description { get; set; }
    }
}
