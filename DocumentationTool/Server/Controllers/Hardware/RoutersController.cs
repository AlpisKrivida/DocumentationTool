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
        public async Task<ActionResult<List<RouterDevice>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Routers
                .Include(x => x.Model)
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RouterDevice>> Get(int id)
        {
            var router = await context.Routers.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.FormFactor)
                .Include(x => x.PowerConsumer)
                .FirstOrDefaultAsync();

            if (router == null)
            {
                return NotFound();
            }

            return router;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<RouterDevice>>> Get()
        {
            var router = await context.Routers.ToListAsync();

            if (router == null)
            {
                return NotFound();
            }

            return router;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(RouterDevice router)
        {
            context.Add(router);
            await context.SaveChangesAsync();
            return router.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(RouterDevice router)
        {
            context.Update(router);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var router = await context.Routers.FirstOrDefaultAsync(x => x.Id == id);
            if (router == null)
            {
                return NotFound();
            }

            context.Remove(router);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}