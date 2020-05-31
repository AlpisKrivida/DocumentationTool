using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.Entities.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public class IPListRepository : IIPListRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/iplist";

        public IPListRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<List<IPList>> GetIPlists(int id)
        {
            return await httpService.GetHelper<List<IPList>>($"{url}/{id}");
        }

        public async Task<List<IPList>> GetAllIPlists()
        {
            return await httpService.GetHelper<List<IPList>>(url);
        }
    }
}
