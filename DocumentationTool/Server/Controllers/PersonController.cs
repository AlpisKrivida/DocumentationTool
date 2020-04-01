using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DocumentationTool.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public PersonController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<MonitorDTO>> Get(int id)
        //{
        //    var limit = 2;

        //    var monitors = await context.Monitors.Where(x => x.Id == id)
        //        .Include(x => x.Model)
        //        .Include(x => x.Description)
        //        .FirstOrDefaultAsync();

        //    var model = new MonitorDTO();

        //    model.Monitor = monitors;
        //    var test = new Model();
        //    model.Model = await context.Models.Where(x => x.Id == monitors.Model.Id)
        //        .Include(x => x.Manufacturer)
        //        .Include(x => x.Description)
        //        .FirstOrDefaultAsync();

        //    return model;
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            int? genId=null;
            int? desId=null;

            var person = await context.Persons.Where(x => x.Id == id)
                .Include(x => x.General)
                .FirstOrDefaultAsync();

            if (person == null)
            {
                return NotFound();
            }

            if (person.General != null) {
                genId = person.General.Id;
            }

            context.Remove(person);     
            //try to remove description and general
            ExtensionsRemoval.RemoveGeneral(context, genId);

            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
