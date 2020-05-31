using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Contacts
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Function { get; set; }
        public string City { get; set; }
        public string EMailAdress { get; set; }
        public string Organization { get; set; }
        public string TelephoneCompany { get; set; }
        public string PersonalNumber { get; set; }
        public string Description { get; set; }
        public General General { get; set; }
        
        public int? ServerId { get; set; }
        public ServerDevice ServerDevice { get; set; }
    }
}
