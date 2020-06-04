using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Infrastructure;
using System.Security.Cryptography.X509Certificates;
using DocumentationTool.Server.Helpers;

namespace DocumentationTool.Server.Controllers.Infrastructure
{
    [ApiController]
    [Route("api/[controller]")]
    public class CablesController : Controller
    {
        private readonly ApplicationDbContext context;
        public CablesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Cable>>> Get()
        {
            var cable = await context.Cables.ToListAsync();

            if (cable == null)
            {
                return NotFound();
            }

            return cable;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cable>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Cables
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cable>> Get(int id)
        {
            var cable = await context.Cables.Where(x => x.Id == id)
                .Include(x => x.General)
                .FirstOrDefaultAsync();

            if (cable == null)
            {
                return NotFound();
            }

            return cable;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Cable cable)
        {
            context.Add(cable);
            await context.SaveChangesAsync();
            return cable.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Cable cable)
        {
            context.Update(cable);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cable = await context.Cables
                .Include(x => x.General)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (cable == null)
            {
                return NotFound();
            }

            context.Remove(cable);

            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}