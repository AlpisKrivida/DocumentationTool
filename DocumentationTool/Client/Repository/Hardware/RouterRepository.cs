using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class RouterRepository : IRouterRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/routers";
        public RouterRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateRouter(RouterDevice router)
        {
            var response = await httpService.Post<RouterDevice, int>(url, router);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteRouter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RouterDevice>> GetAllRouters()
        {
            return await httpService.GetHelper<List<RouterDevice>>(url);
        }

        public async Task<RouterDevice> GetRouter(int id)
        {
            var response = await httpService.Get<RouterDevice>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<RouterDevice>>> GetRouters(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<RouterDevice>>(url, paginationDTO);
        }

        public async Task UpdateRouter(RouterDevice router)
        {
            var response = await httpService.Put(url, router);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
