using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Software
{
    public interface ILicenseRepository
    {
        Task<PaginatedResponse<List<LicenseKey>>> GetLicenseKey(PaginationDTO paginationDTO);
        Task<LicenseKey> GetLicenseKey(int id);
        Task<int> CreateLicenseKey(LicenseKey licenseKey);
        Task DeleteLicenseKey(int id);
        Task UpdateLicenseKey(LicenseKey licenseKey);
        //Task<List<Application>> GetAllApplication();
    }
}
