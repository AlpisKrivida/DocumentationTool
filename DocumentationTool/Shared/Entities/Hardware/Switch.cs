using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class Switch
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Model Model { get; set; }
        public FormFactor FormFactory {get;set;}
        public HostAddress HostAddress { get; set; }
        public string Vlan { get; set; }
        public string Role { get; set; }
        public string SpanningTree { get; set; }
        public string Description { get; set; }

    }
}
