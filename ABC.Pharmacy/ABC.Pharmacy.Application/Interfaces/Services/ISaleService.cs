using ABC.Pharmacy.Application.DTOs.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Services
{
    public interface ISaleService
    {

        Task CreateSaleAsync(CreateSaleDto dto);


        Task<List<SaleDto>> GetSalesAsync();

    }
}
