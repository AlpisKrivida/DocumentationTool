using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Infrastucture
{
    public interface ICableRepository
    {
        Task<PaginatedResponse<List<Cable>>> GetCables(PaginationDTO paginationDTO);
        Task<Cable> GetCable(int id);
        Task<int> CreateCable(Cable cable);
        Task DeleteCable(int id);
        Task UpdateCable(Cable cable);
    }
}
