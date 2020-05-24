using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Software
{
    public class LicenseRepository : ILicenseRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/license";

        public LicenseRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<int> CreateLicenseKey(LicenseKey licenseKey)
        {
            var response = await httpService.Post<LicenseKey, int>(url, licenseKey);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeleteLicenseKey(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<List<LicenseKey>>> GetLicenseKey(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<LicenseKey>>(url, paginationDTO);
        }

        public async Task<LicenseKey> GetLicenseKey(int id)
        {
            var response = await httpService.Get<LicenseKey>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateLicenseKey(LicenseKey licenseKey)
        {
            var response = await httpService.Put(url, licenseKey);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
