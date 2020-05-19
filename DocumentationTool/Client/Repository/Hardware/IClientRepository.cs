using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IClientRepository
    {
        Task<PaginatedResponse<List<ClientPC>>> GetClientPCs(PaginationDTO paginationDTO);
        Task<ClientPC> GetClientPC(int id);
        Task<List<ClientPC>> GetAllClientPC();
        Task<int> CreateClientPC(ClientPC client);
        Task DeleteClientPC(int id);
        Task UpdateClientPC(ClientPC client);
    }
}
