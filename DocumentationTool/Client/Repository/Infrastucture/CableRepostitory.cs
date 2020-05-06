using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Infrastructure;
using DocumentationTool.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Infrastucture
{
    public class CableRepostitory : ICableRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/cables";

        public CableRepostitory(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateCable(Cable cable)
        {
            var response = await httpService.Post<Cable, int>(url, cable);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteCable(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Cable> GetCable(int id)
        {
            var response = await httpService.Get<Cable>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<Cable>>> GetCables(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Cable>>(url, paginationDTO);
        }

        public async Task UpdateCable(Cable cable)
        {
            var response = await httpService.Put(url, cable);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
