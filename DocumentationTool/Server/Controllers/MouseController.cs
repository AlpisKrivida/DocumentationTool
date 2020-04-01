using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MouseController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MouseController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Mouse>>> get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Mouses.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mouse>> Get(int id)
        {
            var genre = await context.Mouses.FirstOrDefaultAsync(x => x.Id == id);
            if (genre == null) { return NotFound(); }
            return genre;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Mouse mouse)
        {
            context.Add(mouse);
            await context.SaveChangesAsync();
            return mouse.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Mouse genre)
        {
            context.Attach(genre).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var genre = await context.Mouses.FirstOrDefaultAsync(x => x.Id == id);
            if (genre == null)
            {
                return NotFound();
            }

            context.Remove(genre);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
