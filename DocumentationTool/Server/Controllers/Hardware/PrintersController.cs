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

namespace DocumentationTool.Server.Controllers.Hardware
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrintersController : Controller
    {
        private readonly ApplicationDbContext context;
        public PrintersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Printer>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Printers.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Printer>> Get(int id)
        {
            var printer = await context.Printers.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.Access)
                .FirstOrDefaultAsync();

            if (printer == null)
            {
                return NotFound();
            }

            return printer;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Printer printer)
        {
            context.Add(printer);
            await context.SaveChangesAsync();
            return printer.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Printer printer)
        {
            context.Update(printer);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movie = await context.Printers.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            context.Remove(movie);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}