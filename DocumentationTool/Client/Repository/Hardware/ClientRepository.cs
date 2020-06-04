using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class ClientRepository : IClientRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/client";

        public ClientRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateClientPC(ClientPC client)
        {
            var response = await httpService.Post<ClientPC, int>(url, client);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }


        public async Task DeleteClientPC(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<ClientPC>> GetAllClientPC()
        {
            return await httpService.GetHelper<List<ClientPC>>(url);
        }

        public async Task<ClientPC> GetClientPC(int id)
        {
            var response = await httpService.Get<ClientPC>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<ClientPC>>> GetClientPCs(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<ClientPC>>(url, paginationDTO);
        }

        public async Task UpdateClientPC(ClientPC client)
        {
            var response = await httpService.Put(url, client);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
