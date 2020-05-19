using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Hardware
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext context;
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ClientPC>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Client
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.Desktop)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientPC>> Get(int id)
        {
            var client = await context.Client.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.CPU)
                .Include(x => x.Memory)
                .Include(x => x.PowerConsumer)
                .Include(x => x.Desktop)
                .FirstOrDefaultAsync();

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<ClientPC>>> Get()
        {
            var client = await context.Client.ToListAsync();

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(ClientPC client)
        {
            context.Add(client);
            await context.SaveChangesAsync();
            return client.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(ClientPC client)
        {
            context.Update(client);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var client = await context.Client.FirstOrDefaultAsync(x => x.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            context.Remove(client);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}