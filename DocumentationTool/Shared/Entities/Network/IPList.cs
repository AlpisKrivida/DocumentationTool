using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace DocumentationTool.Shared.Entities.Network
{
    public class IPList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public ServerDevice Server { get; set; }
        public RouterDevice Router { get; set; }
        public ClientPC Client { get; set; }
        public Switch Switch { get; set; }
        public Printer Printer { get; set; }


        public int? LayerThreeNetId { get; set; }
        public LayerThreeNet LayerThreeNet { get; set; }
    }
}
