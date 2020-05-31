using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortController : Controller
    {
        private readonly ApplicationDbContext context;
        public PortController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<DevicePort>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.DevicePort
                .Include(x => x.Cable)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<DevicePort>>> Get()
        {
            var port = await context.DevicePort.ToListAsync();

            if (port == null)
            {
                return NotFound();
            }

            return port;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DevicePort>> Get(int id)
        {
            var person = await context.DevicePort.Where(x => x.Id == id)
                .Include(x => x.Cable)
                .FirstOrDefaultAsync();

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(DevicePort port)
        {
            context.Add(port);
            await context.SaveChangesAsync();
            return port.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(DevicePort port)
        {
            context.Update(port);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var port = await context.DevicePort.FirstOrDefaultAsync(x => x.Id == id);
            if (port == null)
            {
                return NotFound();
            }

            context.Remove(port);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
