using ABC.Pharmacy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Repositories
{
    public interface ISaleRepository
    {

        Task AddAsync(Sale sale);


        Task<List<Sale>> GetAllAsync();

    }
}
