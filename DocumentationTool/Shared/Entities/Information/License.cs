using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Information
{
    public class License
    {
        public int Id { get; set; }
        public General General { get; set; }
        public List<LicenseKey> Keys { get; set; }
    }
}
