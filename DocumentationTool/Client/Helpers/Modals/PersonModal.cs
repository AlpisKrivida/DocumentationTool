using DocumentationTool.Shared.Entities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Helpers
{
    public class PersonModal
    {
        public bool IsActive { get; set; }
        public Person Person { get; set; }
    }
}
