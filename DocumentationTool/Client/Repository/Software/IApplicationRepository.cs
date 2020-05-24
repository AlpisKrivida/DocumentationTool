using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Sowftware
{
    public interface IApplicationRepository
    {
        Task<PaginatedResponse<List<Application>>> GetApplication(PaginationDTO paginationDTO);
        Task<Application> GetApplication(int id);
        Task<int> CreateApplication(Application application);
        Task DeleteApplication(int id);
        Task UpdateApplication(Application application);
        //Task<List<Application>> GetAllApplication();
    }
}
