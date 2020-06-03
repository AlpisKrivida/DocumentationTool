using DocumentationTool.Shared.Entities.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class HostAddress
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public LayerThreeNet NetAssignment { get; set; }
        public string AddressAllocation { get; set; }
        public IPList Address { get; set; }
        public string HostName { get; set; }
        public string Domain { get; set; }
        public string Description { get; set; }
    }
}
