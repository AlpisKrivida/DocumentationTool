using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface ISwitchRepository
    {
        Task<PaginatedResponse<List<Switch>>> GetSwitches(PaginationDTO paginationDTO);
        Task<Switch> GetSwitch(int id);
        Task<int> CreateSwitch(Switch switchDevice);
        Task DeleteSwitch(int id);
        Task UpdateSwitch(Switch switchDevice);
        Task<List<Switch>> GetAllSwitches();
    }
}
