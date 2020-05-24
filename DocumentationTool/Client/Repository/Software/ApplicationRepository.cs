using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Sowftware
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/application";

        public ApplicationRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateApplication(Application application)
        {
            var response = await httpService.Post<Application, int>(url, application);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public Task DeleteApplication(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<Application>>> GetApplication(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Application>>(url, paginationDTO);
        }

        public async Task<Application> GetApplication(int id)
        {
            var response = await httpService.Get<Application>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateApplication(Application application)
        {
            var response = await httpService.Put(url, application);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
