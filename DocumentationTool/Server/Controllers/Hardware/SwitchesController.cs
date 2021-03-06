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
    public class SwitchesController : Controller
    {
        private readonly ApplicationDbContext context;
        public SwitchesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Switch>>> Get()
        {
            var switchDevice = await context.Switches.ToListAsync();

            if (switchDevice == null)
            {
                return NotFound();
            }

            return switchDevice;
        }

        [HttpGet]
        public async Task<ActionResult<List<Switch>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Switches
                .Include(x => x.Model)
                .Include(x => x.General)
                .AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Switch>> Get(int id)
        {
            var switchDevice = await context.Switches.Where(x => x.Id == id)
                .Include(x => x.Model)
                .Include(x => x.General)
                .Include(x => x.Model)
                .Include(x => x.FormFactor)
                .Include(x => x.PowerConsumer)
                .FirstOrDefaultAsync();

            if (switchDevice == null)
            {
                return NotFound();
            }

            return switchDevice;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Switch switchDevice)
        {
            context.Add(switchDevice);
            await context.SaveChangesAsync();
            return switchDevice.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Switch switchDevice)
        {
            context.Update(switchDevice);

            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movie = await context.Switches.FirstOrDefaultAsync(x => x.Id == id);
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