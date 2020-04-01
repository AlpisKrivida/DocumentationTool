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
    public class ServersController : Controller
    {
        private readonly ApplicationDbContext context;
        public ServersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServerDevice>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.ServerDevices.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServerDevice>> Get(int id)
        {
            var server = await context.ServerDevices.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.FormFactor)
                .Include(x => x.Access)
                .Include(x => x.CPU)
                .Include(x => x.Memory)
                .FirstOrDefaultAsync();

            if (server == null)
            {
                return NotFound();
            }

            return server;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(ServerDevice server)
        {
            context.Add(server);
            await context.SaveChangesAsync();
            return server.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(ServerDevice server)
        {
            context.Update(server);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movie = await context.ServerDevices.FirstOrDefaultAsync(x => x.Id == id);
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