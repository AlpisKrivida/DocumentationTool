using DocumentationTool.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public class HostAddressRepository : IHostAddress
    {
        private readonly IHttpService httpService;
        private string url = "api/hostaddress";

        public HostAddressRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateHostAddress(HostAddressRepository hostAddress)
        {
            var response = await httpService.Post<HostAddressRepository, int>(url, hostAddress);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task<HostAddressRepository> GetHostAddress(int id)
        {
            var response = await httpService.Get<HostAddressRepository>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}
