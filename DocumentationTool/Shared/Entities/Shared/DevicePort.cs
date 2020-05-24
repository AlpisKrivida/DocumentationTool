using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class DevicePort
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Plug { get; set; }

        //Speed
        public string Negotiation { get; set; }
        public string Duplex { get; set; }
        public int Speed { get; set; }
        public string SpeedMeasure { get; set; }

        public string Mac { get; set; }

        //Cable
        public List<PortCable> Cables { get; set; }

        //Device Input
        public int? SwitchInputId { get; set; }
        public Switch Switch { get; set; }

        public int? RouterInpuId { get; set; }
        public RouterDevice Router { get; set; }

        public int? ServerInpuId { get; set; }
        public ServerDevice ServerDevice { get; set; }

        //Device Output
        public int? SwitchOutputId { get; set; }
        public int? RouterOutputd { get; set; }
        public int? ServerOutputId { get; set; }
    }
}
