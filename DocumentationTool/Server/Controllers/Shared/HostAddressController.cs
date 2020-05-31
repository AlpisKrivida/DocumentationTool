using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class HostAddressController : Controller
    {
        private readonly ApplicationDbContext context;
        public HostAddressController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<DevicePort>>> Get([FromQuery] PaginationDTO paginationDTO)
        //{
        //    var queryable = context.DevicePort
        //        .Include(x => x.Cable)
        //        .AsQueryable();
        //    await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
        //    return await queryable.Paginate(paginationDTO).ToListAsync();
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<HostAddress>> Get(int id)
        {
            var addres = await context.HostAddresses.Where(x => x.Id == id)
                .Include(x => x.NetAssignment)
                .FirstOrDefaultAsync();

            if (addres == null)
            {
                return NotFound();
            }

            return addres;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(HostAddress address)
        {
            context.Add(address);
            await context.SaveChangesAsync();
            return address.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(HostAddress address)
        {
            context.Update(address);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var address = await context.HostAddresses.FirstOrDefaultAsync(x => x.Id == id);
            if (address == null)
            {
                return NotFound();
            }

            context.Remove(address.NetAssignment);
            context.Remove(address);

            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}