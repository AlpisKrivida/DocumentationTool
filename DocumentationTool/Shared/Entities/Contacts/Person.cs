﻿using DocumentationTool.Shared.Entities.Hardware;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTool.Shared.Entities.Contacts
{
    public class Person
    {
        public int Id { get; set; }
        public string AcademicDegree { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Function { get; set; }
        public string ServiceDesignation { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string EMailAdress { get; set; }
        public string TelephoneCompany { get; set; }
        public string TelephoneHome { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Pager { get; set; }
        public string PersonalNumber { get; set; }
        public string Department { get; set; }
        public string Organisation { get; set; }
        public string Description { get; set; }
        public General General { get; set; }
    }
}