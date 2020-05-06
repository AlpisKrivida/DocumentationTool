using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Contacts
{
    public interface IPersonRepostiroy
    {
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO);
        Task<Person> GetPerson(int id);
        Task<int> CreatePerson(Person person);
        Task DeletePerson(int id);
        Task UpdatePerson(Person person);
        Task<List<Person>> GetAllPeople();
    }
}
