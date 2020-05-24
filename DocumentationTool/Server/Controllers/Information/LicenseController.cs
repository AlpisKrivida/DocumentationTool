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
        public async Task<ActionResult<List<LicenseKey>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.LicenseKeys
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LicenseKey>> Get(int id)
        {
            var license = await context.LicenseKeys.Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (license == null)
            {
                return NotFound();
            }

            return license;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(LicenseKey license)
        {
            context.Add(license);
            await context.SaveChangesAsync();
            return license.Id;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<LicenseKey>>> Get()
        {
            var license = await context.LicenseKeys.ToListAsync();

            if (license == null)
            {
                return NotFound();
            }

            return license;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Application license)
        {
            context.Update(license);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var license = await context.LicenseKeys.FirstOrDefaultAsync(x => x.Id == id);
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
