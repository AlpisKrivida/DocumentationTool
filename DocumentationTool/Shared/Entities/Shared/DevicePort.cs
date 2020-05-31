using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Switch = DocumentationTool.Shared.Entities.Hardware.Switch;

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

        //With list
        public int? CableId { get; set; }
        public Cable Cable { get; set; }
        public int? ServerId { get; set; }
        public ServerDevice ServerDevice { get; set; }
        public int? SwitchId { get; set; }
        public Switch SwitchDevice { get; set; }
        public int? RouterId { get; set; }
        public RouterDevice RouterDevice { get; set; }
        public int? PrinterId { get; set; }
        public Printer Printer { get; set; }

        //Device Input
        public int? SwitchInputId { get; set; }
        public int? RouterInpuId { get; set; }
        public int? ServerInpuId { get; set; }
        public int? PrinterInputId { get; set; }

        //Device Output
        public int? SwitchOutputId { get; set; }
        public int? RouterOutputd { get; set; }
        public int? ServerOutputId { get; set; }
        public int? PrinterOutputId { get; set; }
    }
}
