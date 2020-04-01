using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class Access
    {
        public int Id { get; set; }
        public string AccessType { get; set; }
        public string Host { get; set; }
        public bool Primary { get; set; }
        public string Description { get; set; }

    }
}
