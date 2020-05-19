using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IRouterRepository
    {
        Task<PaginatedResponse<List<RouterDevice>>> GetRouters(PaginationDTO paginationDTO);
        Task<RouterDevice> GetRouter(int id);
        Task<int> CreateRouter(RouterDevice router);
        Task DeleteRouter(int id);
        Task UpdateRouter(RouterDevice router);
        Task<List<RouterDevice>> GetAllRouters();
    }
}
