using ABC.Pharmacy.Application.DTOs.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Services
{
    public interface IMedicineService
    {

        Task<List<MedicineDto>> GetAllAsync();


        Task CreateAsync(CreateMedicineDto dto);

    }
}
