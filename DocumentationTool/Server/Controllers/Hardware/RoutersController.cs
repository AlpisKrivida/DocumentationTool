﻿using Microsoft.AspNetCore.Mvc;
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
    public class RoutersController : Controller
    {
        private readonly ApplicationDbContext context;
        public RoutersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Router>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Routers.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Router>> Get(int id)
        {
            var router = await context.Routers.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.Access)
                .Include(x => x.HostAddress)
                .Include(x => x.Model)
                .Include(x => x.FormFactor)
                .Include(x => x.PowerConsumer)
                .FirstOrDefaultAsync();

            if (router == null)
            {
                return NotFound();
            }

            return router;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Router router)
        {
            context.Add(router);
            await context.SaveChangesAsync();
            return router.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Router router)
        {
            context.Update(router);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movie = await context.Routers.FirstOrDefaultAsync(x => x.Id == id);
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