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

namespace DocumentationTool.Server.Controllers.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelController : Controller
    {
        private readonly ApplicationDbContext context;
        public ModelController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> Get(int id)
        {
            var model = await context.Models.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null) { return NotFound(); }
            return model;
        }
    }
}