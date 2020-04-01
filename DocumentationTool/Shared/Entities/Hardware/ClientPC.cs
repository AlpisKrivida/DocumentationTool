using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class ClientPC
    {
        public int Id { get; set; }
        public General Genral { get; set; }
        public Model Model { get; set; }
        public HostAddress HostAddress { get; set; }
        public Memory Memory { get; set; }
        public CPU CPU { get; set; }
        public Desktop Desktop { get; set; }
    }
}
