using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DocumentationTool.Server.Controllers.Hardware
{
    [ApiController]
    [Route("api/[controller]")]
    public class BladeChassisController : Controller
    {
        private readonly ApplicationDbContext context;
        public BladeChassisController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<BladeChasis>>> get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.BladeChases.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BladeChasis>> Get(int id)
        {
            var bladeChasis = await context.BladeChases.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.FormFactor)
                .Include(x => x.PowerConsumer)
                .FirstOrDefaultAsync();

            if (bladeChasis == null)
            {
                return NotFound();
            }

            return bladeChasis;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(BladeChasis bladeChasis)
        {
            context.Add(bladeChasis);
            await context.SaveChangesAsync();
            return bladeChasis.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(BladeChasis bladeChasis)
        {
            context.Update(bladeChasis);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bladeChasis = await context.BladeChases.FirstOrDefaultAsync(x => x.Id == id);
            if (bladeChasis == null)
            {
                return NotFound();
            }

            context.Remove(bladeChasis);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}