using DocumentationTool.Shared.Entities.Infrastructure;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class ServerDevice
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Model Model { get; set; }
        public FormFactor FormFactor { get; set; }
        public CPU CPU { get; set; }
        public PowerConsumer PowerConsumer { get; set; }
        public Memory Memory { get; set; }

        public List<DevicePort> DevicePorts { get; set; }
    }
}
