using DocumentationTool.Shared.DTOs;
using DocumentationTool.Shared.Entities.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Repository.Hardware
{
    public interface IPrinterRepository
    {
        Task<PaginatedResponse<List<Printer>>> GetPrinters(PaginationDTO paginationDTO);
        Task<Printer> GetPrinter(int id);
        Task<int> CreatePrinter(Printer printer);
        Task DeletePrinter(int id);
        Task UpdatePrinter(Printer printer);
        Task<List<Printer>> GetAllPrintersPC();
    }
}
