using DocumentationTool.Shared.Entities.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public interface IIPListRepository
    {
        Task<List<IPList>> GetIPlists(int id);
        Task<List<IPList>> GetAllIPlists();
    }
}
