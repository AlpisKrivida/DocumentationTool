using DocumentationTool.Shared.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class PortCable
    {
        public int PortId { get; set; }
        public DevicePort DevicePort { get; set; }
        public int CableId { get; set; }
        public Cable Cable { get; set; }
    }
}
