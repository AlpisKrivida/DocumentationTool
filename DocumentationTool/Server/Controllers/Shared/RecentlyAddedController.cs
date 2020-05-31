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
    public class RecentlyAddedController : Controller
    {
        private readonly ApplicationDbContext context;
        public RecentlyAddedController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<RecentlyAdded>>> Get()
        {
            var added = await context.RecentlyAddeds.ToListAsync();

            if (added == null)
            {
                return NotFound();
            }

            return added;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(RecentlyAdded added)
        {
            var mostRecent = await context.RecentlyAddeds.ToListAsync();

            if (mostRecent.Count >= 10)
            {
                var first = mostRecent.First();
                context.Remove(first);
            }

            context.Add(added);
            await context.SaveChangesAsync();
            return added.Id;
        }
    }
}