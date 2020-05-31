using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Shared.Entities.Common;
using DocumentationTool.Shared.Entities.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocumentationTool.Server.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManufacturerController : Controller
    {
        private readonly ApplicationDbContext context;
        public ManufacturerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<ManufacturerNames>>> Get()
        {
            var manufacturers = await context.ManufacturerNames.ToListAsync();

            if (manufacturers == null)
            {
                return NotFound();
            }

            return manufacturers;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(ManufacturerNames manufacturer)
        {
            context.Add(manufacturer);
            await context.SaveChangesAsync();
            return manufacturer.Id;
        }


    }
}