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
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContext context;
        public ApplicationController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Application>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Applications
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> Get(int id)
        {
            var software = await context.Applications.Where(x => x.Id == id)
                .Include(x => x.General)
                .Include(x => x.LicenseKeys)
                .FirstOrDefaultAsync();

            if (software == null)
            {
                return NotFound();
            }

            return software;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Application application)
        {
            context.Add(application);
            await context.SaveChangesAsync();
            return application.Id;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Application>>> Get()
        {
            var software = await context.Applications.ToListAsync();

            if (software == null)
            {
                return NotFound();
            }

            return software;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Application software)
        {
            context.Update(software);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var software = await context.Applications.FirstOrDefaultAsync(x => x.Id == id);
            if (software == null)
            {
                return NotFound();
            }

            context.Remove(software);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}