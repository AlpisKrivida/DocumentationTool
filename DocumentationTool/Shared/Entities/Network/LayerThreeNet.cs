using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Network
{
    public class LayerThreeNet
    {
        public int Id { get; set; }
        public General General { get; set; }
        public string Type { get; set; }
        public string Net { get; set; }
        public string Prefix { get; set; }
        public string NetMask { get; set; }
        public string DNSDomain { get; set; }
        public string Description { get; set; }

        public List<IPList> IpLists { get; set; }
    }
}
