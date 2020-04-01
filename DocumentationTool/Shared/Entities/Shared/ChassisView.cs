using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class ChassisView
    {
        public int Id { get; set; }
        public int FrontHorizontalUnit { get; set; }
        public int VerticalUnits { get; set; }
        public string FrontGridSize { get; set; }
        public string RearHorizontalUnits {get;set;}
        public string RearVerticalUnits { get; set; }
        public string RearGridSize { get; set; }
        public string Description { get; set; }
    }
}
