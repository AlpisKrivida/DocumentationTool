using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class Model
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string ServiceTag { get; set; }
        public string ProductID { get; set; }
        public string SerialNumber { get; set; }
        public string Firmware { get; set; }
        public string Description { get; set; }

    }
}
