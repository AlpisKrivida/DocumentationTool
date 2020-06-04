using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Contacts
{
    public class PersonRepository : IPersonRepostiroy
    {
        private readonly IHttpService httpService;
        private string url = "api/person";

        public PersonRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Person>> GetAllPeople()
        {
            return await httpService.GetHelper<List<Person>>(url);
        }

        public async Task<int> CreatePerson(Person person)
        {
            var response = await httpService.Post<Person, int>(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeletePerson(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Person>>(url, paginationDTO);
        }

        public async Task<Person> GetPerson(int id)
        {
            
            var response = await httpService.Get<Person>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdatePerson(Person person)
        {
            var response = await httpService.Put(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
