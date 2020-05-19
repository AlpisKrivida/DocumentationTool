using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Information;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Information
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicenseController : Controller
    {
        private readonly ApplicationDbContext context;
        public LicenseController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<License>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Licenses
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<License>> Get(int id)
        {
            var monitor = await context.Licenses.Where(x => x.Id == id)
                .Include(x => x.General)
                .Include(x => x.Keys)
                .FirstOrDefaultAsync();

            if (monitor == null)
            {
                return NotFound();
            }

            return monitor;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(License license)
        {
            context.Add(license);
            await context.SaveChangesAsync();
            return license.Id;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<License>>> Get()
        {
            var license = await context.Licenses.ToListAsync();

            if (license == null)
            {
                return NotFound();
            }

            return license;
        }

        [HttpPut]
        public async Task<ActionResult> Put(License license)
        {
            context.Update(license);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var license = await context.Licenses.FirstOrDefaultAsync(x => x.Id == id);
            if (license == null)
            {
                return NotFound();
            }

            context.Remove(license);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}