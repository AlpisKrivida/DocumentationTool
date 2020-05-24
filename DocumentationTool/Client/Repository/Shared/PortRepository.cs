using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Shared
{
    public class PortRepository : IPortRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/port";

        public PortRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateDevicePort(DevicePort port)
        {
            var response = await httpService.Post<DevicePort, int>(url, port);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteDevicePort(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<DevicePort>>> GetDevicePort(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<DevicePort>>(url, paginationDTO);
        }

        public async Task<DevicePort> GetDevicePort(int id)
        {
            var response = await httpService.Get<DevicePort>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateDevicePort(DevicePort port)
        {
            var response = await httpService.Put(url, port);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
