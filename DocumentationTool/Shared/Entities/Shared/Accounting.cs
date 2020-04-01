using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Shared
{
    public class Accounting
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DateOfInvoice { get; set; }

        public string Description { get; set; }
    }
}
