using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IServerRepository
    {
        Task<PaginatedResponse<List<ServerDevice>>> GetServerDevices(PaginationDTO paginationDTO);
        Task<ServerDevice> GetServerDevice(int id);
        Task<int> CreateServerDevice(ServerDevice server);
        Task DeleteServerDevice(int id);
        Task UpdateServerDevice(ServerDevice server);
        Task<List<ServerDevice>> GetAllServers();
    }
}
