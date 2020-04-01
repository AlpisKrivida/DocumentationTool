using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IBladeChassisRepository
    {
        Task<PaginatedResponse<List<BladeChasis>>> GetBladeChasises(PaginationDTO paginationDTO);
        Task<BladeChasis> GetBladeChasis(int id);
        Task CreateBladeChasis(BladeChasis bladeChasis);
        Task DeleteBladeChasis(int id);
        Task UpdateBladeChasis(BladeChasis bladeChasis);
    }
}
