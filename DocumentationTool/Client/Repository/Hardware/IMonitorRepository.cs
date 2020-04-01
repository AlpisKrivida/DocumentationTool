using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IMonitorRepository
    {
        Task<PaginatedResponse<List<Monitor>>> GetMonitors(PaginationDTO paginationDTO);
        Task<Monitor> GetMonitor(int id);
        Task<int> CreateMonitor(Monitor monitor);
        Task DeleteMonitor(int id);
        Task UpdateMonitor(Monitor monitor);
    }
}
