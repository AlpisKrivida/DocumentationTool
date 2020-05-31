using DocumentationTool.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Network
{
    public class HostAddress : IHostAddress
    {
        private readonly IHttpService httpService;
        private string url = "api/hostaddress";

        public HostAddress(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateHostAddress(HostAddress hostAddress)
        {
            var response = await httpService.Post<HostAddress, int>(url, hostAddress);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task<HostAddress> GetHostAddress(int id)
        {
            var response = await httpService.Get<HostAddress>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}
