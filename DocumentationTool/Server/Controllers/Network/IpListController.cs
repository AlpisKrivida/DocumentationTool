using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Shared.Entities.Network;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("{id}")]
        public async Task<ActionResult<List<IPList>>> Get(int id)
        {
            var iplists = await context.IpLists
                .Include(x => x.Server)
                .Include(x => x.Printer)
                .Include(x => x.Switch)
                .Include(x => x.Client)
                .Where(x => x.LayerThreeNetId == id)
                .ToListAsync();

            if (iplists == null)
            {
                return NotFound();
            }
            return iplists;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<IPList>>> Get()
        {
            var iplist = await context.IpLists
                .Include(x => x.Server)
                .Include(x => x.Printer)
                .Include(x => x.Switch)
                .Include(x => x.Client)
                .ToListAsync();

            if (iplist == null)
            {
                return NotFound();
            }

            return iplist;
        }
    }
}