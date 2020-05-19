using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Information
{
    public class Application
    {
        public int Id { get; set; }
        public General General { get; set; }
        public string Manufacturer { get; set; }
        public string RegistrationKey { get; set; }
        public string Description { get; set; }
    }
}
