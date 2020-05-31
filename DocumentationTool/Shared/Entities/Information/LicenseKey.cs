using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Information
{
    public class LicenseKey
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Key { get; set; }
        public string Serial { get; set; }
        public DateTime ExpireDate { get; set; }
        public double PricePerUnit { get; set; }
        public string Description { get; set; }

        public int? ApplicationId { get; set; }
        public Application Application { get; set; }
        public int? ServerId { get; set; }
        public ServerDevice ServerDevice { get; set; }
    }
}
