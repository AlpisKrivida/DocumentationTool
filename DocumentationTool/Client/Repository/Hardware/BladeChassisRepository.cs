using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class BladeChassisRepository : IBladeChassisRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/bladechassis";

        public BladeChassisRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public Task CreateBladeChasis(BladeChasis bladeChasis)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBladeChasis(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BladeChasis> GetBladeChasis(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<BladeChasis>>> GetBladeChasises(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<BladeChasis>>(url, paginationDTO);
        }

        public Task UpdateBladeChasis(BladeChasis bladeChasis)
        {
            throw new NotImplementedException();
        }
    }
}
