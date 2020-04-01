using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class ServerRepository : IServerRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/servers";

        public ServerRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateServerDevice(ServerDevice server)
        {
            var response = await httpService.Post<ServerDevice, int>(url, server);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteServerDevice(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServerDevice> GetServerDevice(int id)
        {
            var response = await httpService.Get<ServerDevice>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<ServerDevice>>> GetServerDevices(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<ServerDevice>>(url, paginationDTO);
        }

        public async Task UpdateServerDevice(ServerDevice server)
        {
            var response = await httpService.Put(url, server);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
