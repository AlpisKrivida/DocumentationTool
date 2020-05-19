using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DocumentationTool.Server.Controllers.Information
{
    public class SoftwareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}