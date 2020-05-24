using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Shared
{
    public interface IPortRepository
    {
        Task<PaginatedResponse<List<DevicePort>>> GetDevicePort(PaginationDTO paginationDTO);
        Task<DevicePort> GetDevicePort(int id);
        Task<int> CreateDevicePort(DevicePort port);
        Task DeleteDevicePort(int id);
        Task UpdateDevicePort(DevicePort port);
        //Task<List<Person>> GetAllPeople();
    }
}
