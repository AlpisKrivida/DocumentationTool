using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class MonitorRepository: IMonitorRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/monitor";

        public MonitorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateMonitor(Monitor monitor)
        {
            var response = await httpService.Post<Monitor, int>(url, monitor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }


        public async Task DeleteMonitor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Monitor>> GetAllMonitors()
        {
            return await httpService.GetHelper<List<Monitor>>(url);
        }

        public async Task<Monitor> GetMonitor(int id)
        {
            var response = await httpService.Get<Monitor>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<Monitor>>> GetMonitors(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Monitor>>(url, paginationDTO);
        }

        public async Task UpdateMonitor(Monitor monitor)
        {
            var response = await httpService.Put(url, monitor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
