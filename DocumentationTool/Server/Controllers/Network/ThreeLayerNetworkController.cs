using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Network;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Network
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class ThreeLayerNetworkController : Controller
    {
        private readonly ApplicationDbContext context;
        public ThreeLayerNetworkController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<LayerThreeNet>>> Get()
        {
            var network = await context.LayerThreeNets.ToListAsync();

            if (network == null)
            {
                return NotFound();
            }

            return network;
        }

        [HttpGet]
        public async Task<ActionResult<List<LayerThreeNet>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.LayerThreeNets
                .Include(x => x.General)
                .Include(x => x.IpLists)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LayerThreeNet>> Get(int id)
        {
            var network = await context.LayerThreeNets.Where(x => x.Id == id)
                .Include(x => x.General)
                .FirstOrDefaultAsync();

            if (network == null)
            {
                return NotFound();
            }

            return network;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(LayerThreeNet network)
        {
            context.Add(network);
            await context.SaveChangesAsync();
            return network.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(LayerThreeNet network)
        {
            context.Update(network);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var network = await context.LayerThreeNets
                .Include(x => x.General)
                .Include(x => x.IpLists)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (network == null)
            {
                return NotFound();
            }
            
            context.Remove(network);

            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}