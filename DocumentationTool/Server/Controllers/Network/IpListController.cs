using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DocumentationTool.Server.Controllers.Network
{
    [ApiController]
    [Route("api/[controller]")]
    public class IpListController : Controller
    {
        private readonly ApplicationDbContext context;
        public IpListController(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}