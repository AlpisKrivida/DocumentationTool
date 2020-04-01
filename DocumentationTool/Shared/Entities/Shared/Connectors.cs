using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class Connectors
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string InOutput { get; set; }
        public bool CreateOutput { get; set; }
        public string Description { get; set; }
    }
}
