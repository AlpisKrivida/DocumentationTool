using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public interface INetworkRepository
    {
        Task<PaginatedResponse<List<LayerThreeNet>>> GetLayerThreeNet(PaginationDTO paginationDTO);
        Task<LayerThreeNet> GetLayerThreeNet(int id);
        Task<int> CreateLayerThreeNet(LayerThreeNet layerThreeNet);
        Task DeleteLayerThreeNet(int id);
        Task UpdateLayerThreeNet(LayerThreeNet layerThreeNet);
        Task<List<LayerThreeNet>> GetAllLayerThreeNet();
    }
}
