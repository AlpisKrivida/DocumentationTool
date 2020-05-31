using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Helpers
{
    public class DeviceModal
    {
        public bool IsActive { get; set; }
        public RouterDevice Router { get; set; }
        public Switch Switch { get; set; }
    }
}
