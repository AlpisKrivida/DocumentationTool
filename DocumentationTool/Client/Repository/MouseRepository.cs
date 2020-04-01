using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository
{
    public class MouseRepository : IMouseRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/mouse";

        public MouseRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateMouse(Mouse mouse)
        {
            var response = await httpService.Post(url, mouse);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public Task DeleteMouse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mouse> GetMouse(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<Mouse>>> GetMouses(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Mouse>>(url, paginationDTO);
        }

        public Task UpdateMouse(Mouse mouse)
        {
            throw new NotImplementedException();
        }
    }
}
