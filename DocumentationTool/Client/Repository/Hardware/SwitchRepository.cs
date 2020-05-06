using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class SwitchRepository : ISwitchRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/switches";

        public SwitchRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateSwitch(Switch switchDevice)
        {
            var response = await httpService.Post<Switch, int>(url, switchDevice);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteSwitch(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Switch> GetSwitch(int id)
        {
            var response = await httpService.Get<Switch>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<Switch>>> GetSwitches(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Switch>>(url, paginationDTO);
        }

        public async Task UpdateSwitch(Switch switchDevice)
        {
            var response = await httpService.Put(url, switchDevice);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
