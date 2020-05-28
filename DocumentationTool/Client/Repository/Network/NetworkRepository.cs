using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public class NetworkRepository : INetworkRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/threelayernetwork";

        public NetworkRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateLayerThreeNet(LayerThreeNet layerThreeNet)
        {
            var response = await httpService.Post<LayerThreeNet, int>(url, layerThreeNet);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteLayerThreeNet(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<LayerThreeNet>>> GetLayerThreeNet(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<LayerThreeNet>>(url, paginationDTO);
        }

        public async Task<LayerThreeNet> GetLayerThreeNet(int id)
        {
            var response = await httpService.Get<LayerThreeNet>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateLayerThreeNet(LayerThreeNet layerThreeNet)
        {
            var response = await httpService.Put(url, layerThreeNet);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
