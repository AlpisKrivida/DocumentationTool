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
            var iplists = await context.IpLists.Where(x => x.LayerThreeNetId == id)
                .ToListAsync();

            if (iplists == null)
            {
                return NotFound();
            }

            return iplists;
        }
    }
}