using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class Router
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Access Access { get; set; }
        public HostAddress HostAddress { get; set; }
        public Model Model { get; set; }
        public FormFactor FormFactor {get;set;}
        public PowerConsumer PowerConsumer { get; set; }
        public string RoutingProtocol { get; set; }
        public string GatewayAddress { get; set; }
        public string Description { get; set; }

    }
}
