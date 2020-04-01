﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class HostAddress
    {
        public int Id { get; set; }
        public bool Primary { get; set; }
        public bool Active { get; set; }
        public string AddressStartRange { get; set; }
        public string AdressEndRange { get; set; }
        public string NetZone { get; set; }
        public string AddressAllocation { get; set; }
        public string IPV4Address { get; set; }
        public bool DefaultGatewayForNet { get; set; }
        public string HostName { get; set; }
        //DNS server
        public string SearchDomain { get; set; }
        public string AssignedPort { get; set; }
        public string Description { get; set; }
    }
}
