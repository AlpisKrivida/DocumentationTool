using DocumentationTool.Client.Helpers;
using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public class PrinterRepository : IPrinterRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/printers";

        public PrinterRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreatePrinter(Printer printer)
        {
            var response = await httpService.Post<Printer, int>(url, printer);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task DeletePrinter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Printer>> GetAllPrintersPC()
        {
            return await httpService.GetHelper<List<Printer>>(url);
        }

        public async Task<Printer> GetPrinter(int id)
        {
            var response = await httpService.Get<Printer>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<PaginatedResponse<List<Printer>>> GetPrinters(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Printer>>(url, paginationDTO);
        }

        public async Task UpdatePrinter(Printer printer)
        {
            var response = await httpService.Put(url, printer);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
