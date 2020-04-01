using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentationTool.Server.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DocumentationTool.Server.Controllers.Hardware
{
    [ApiController]
    [Route("api/[controller]")]
    public class BladeChassisController : Controller
    {
        private readonly ApplicationDbContext context;
        public BladeChassisController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<BladeChasis>>> get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.BladeChases.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }
    }
}