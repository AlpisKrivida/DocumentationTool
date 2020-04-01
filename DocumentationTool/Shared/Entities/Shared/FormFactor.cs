using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class FormFactor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RackUnit { get; set; }
        public string DimesnsionUnit { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public string WeightMeasure { get; set; }
        public string Description { get; set; }

    }
}
