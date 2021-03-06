﻿using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace DocumentationTool.Shared.Entities.Hardware
{
    public class General
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public DateTime CreatioDate { get; set; }
        public DateTime DateOfChange { get; set; }
        public List<string> Tag { get; set; }
        public string Description { get; set; }
    }
}
