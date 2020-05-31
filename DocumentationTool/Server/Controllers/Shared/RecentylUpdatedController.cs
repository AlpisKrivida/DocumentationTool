using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Shared.Entities.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecentylUpdatedController : Controller
    {
        private readonly ApplicationDbContext context;
        public RecentylUpdatedController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<RecentlyUpdated>>> Get()
        {
            var mostRecent = await context.RecentlyUpdateds.ToListAsync();

            if (mostRecent == null)
            {
                return NotFound();
            }

            return mostRecent;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(RecentlyUpdated recent)
        {
            var mostRecent = await context.ManufacturerNames.ToListAsync();

            if (mostRecent.Count >= 10)
            {
                var first = mostRecent.First();
                context.Remove(first);
            }

            context.Add(recent);
            await context.SaveChangesAsync();
            return recent.Id;
        }

    }
}