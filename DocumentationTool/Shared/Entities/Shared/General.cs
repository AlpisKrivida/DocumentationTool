using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class General
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Purpose { get; set; }
        public string Condition { get; set; }
        public string CMDBStatus { get; set; }
        public string ObjectID { get; set; }
        public string ObjectType { get; set; }
        public string SYSID { get; set; }
        public DateTime CreatioDate { get; set; }
        public DateTime DateOfChange { get; set; }
        public string Description { get; set; }
    }
}
