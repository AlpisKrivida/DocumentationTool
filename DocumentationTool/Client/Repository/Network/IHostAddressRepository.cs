using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public interface IHostAddress
    {
        Task<HostAddressRepository> GetHostAddress(int id);
        Task<int> CreateHostAddress(HostAddressRepository layerThreeNet);
    }
}
