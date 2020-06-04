using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System.Security.Cryptography.X509Certificates;
using DocumentationTool.Server.Helpers;

namespace DocumentationTool.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonitorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public MonitorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Monitor>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Monitors
                .Include(x => x.Model)
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Monitor>> Get(int id)
        {
            var monitor = await context.Monitors.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.FormFactor)
                .Include(x => x.PowerConsumer)
                .FirstOrDefaultAsync();

            if(monitor == null)
            {
                return NotFound();
            }

            return monitor;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Monitor monitor)
        {
            context.Add(monitor);
            await context.SaveChangesAsync();
            return monitor.Id;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Monitor>>> Get()
        {
            var monitor = await context.Monitors.ToListAsync();

            if (monitor == null)
            {
                return NotFound();
            }

            return monitor;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Monitor monitor)
        {
            context.Update(monitor);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var monitor = await context.Monitors
                .Include(x => x.General)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (monitor == null)
            {
                return NotFound();
            }
            
            context.Remove(monitor);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
