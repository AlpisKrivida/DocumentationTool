using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IRouterRepository
    {
        Task<PaginatedResponse<List<Router>>> GetRouters(PaginationDTO paginationDTO);
        Task<Router> GetRouter(int id);
        Task<int> CreateRouter(Router router);
        Task DeleteRouter(int id);
        Task UpdateRouter(Router router);
    }
}
