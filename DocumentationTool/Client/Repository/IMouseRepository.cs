using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository
{
    public interface IMouseRepository
    {
        Task<PaginatedResponse<List<Mouse>>> GetMouses(PaginationDTO paginationDTO);
        Task<Mouse> GetMouse(int id);
        Task CreateMouse(Mouse mouse);
        Task DeleteMouse(int id);
        Task UpdateMouse(Mouse mouse);
    }
}
