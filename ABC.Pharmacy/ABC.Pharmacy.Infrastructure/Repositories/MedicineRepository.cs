using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Domain.Entities;
using ABC.Pharmacy.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Infrastructure.Repositories
{
    public class MedicineRepository
: IMedicineRepository
    {


        private readonly JsonDbContext _context;


        private const string FileName =
        "medicines.json";



        public MedicineRepository(
        JsonDbContext context)
        {

            _context = context;

        }




        public async Task<List<Medicine>>
        GetAllAsync()
        {

            return await _context
            .ReadAsync<Medicine>(FileName);

        }




        public async Task<Medicine?>
        GetByIdAsync(Guid id)
        {


            var list =
            await GetAllAsync();


            return list.FirstOrDefault(
            x => x.Id == id);

        }




        public async Task AddAsync(
        Medicine medicine)
        {

            var list =
            await GetAllAsync();


            list.Add(medicine);


            await _context
            .WriteAsync(
            FileName, list);

        }




        public async Task UpdateAsync(
        Medicine medicine)
        {

            var list =
            await GetAllAsync();


            var index =
            list.FindIndex(
            x => x.Id == medicine.Id);



            if (index >= 0)

                list[index] = medicine;



            await _context
            .WriteAsync(
            FileName, list);

        }





        public async Task DeleteAsync(
        Guid id)
        {


            var list =
            await GetAllAsync();


            list.RemoveAll(
            x => x.Id == id);



            await _context
            .WriteAsync(
            FileName, list);


        }


    }
}
