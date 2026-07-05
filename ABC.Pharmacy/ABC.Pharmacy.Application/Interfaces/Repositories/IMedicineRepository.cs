using ABC.Pharmacy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Repositories
{
    public interface IMedicineRepository
    {

        Task<List<Medicine>> GetAllAsync();


        Task<Medicine?> GetByIdAsync(Guid id);


        Task AddAsync(Medicine medicine);


        Task UpdateAsync(Medicine medicine);


        Task DeleteAsync(Guid id);

    }
}
