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
        public async Task<int> CreateRouter(Router router)
        {
            var response = await httpService.Post<Router, int>(url, router);
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

        public async Task<Router> GetRouter(int id)
        {
            var response = await httpService.Get<Router>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<Router>>> GetRouters(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Router>>(url, paginationDTO);
        }

        public async Task UpdateRouter(Router router)
        {
            var response = await httpService.Put(url, router);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
