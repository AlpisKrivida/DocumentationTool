using DocumentationTool.Shared.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Helpers
{
    public class CableModal
    {
        public bool IsActive { get; set; }
        public Cable Cable { get; set; }
    }
}
