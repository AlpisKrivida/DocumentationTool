using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class BladeChasis
    {
        public int Id { get; set; }
        public General General { get; set; }
        public Access Access { get; set; }
        public FormFactor FormFactor { get; set; }
        public Model Model { get; set; }
        public PowerConsumer PowerConsumer { get; set; }
    }
}
