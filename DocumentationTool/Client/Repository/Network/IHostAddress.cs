using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public interface IHostAddress
    {
        Task<HostAddress> GetHostAddress(int id);
        Task<int> CreateHostAddress(HostAddress layerThreeNet);
    }
}
