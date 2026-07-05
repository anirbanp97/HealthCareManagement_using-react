using ABC.Pharmacy.Application.DTOs.Medicine;
using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Interfaces.Services;
using ABC.Pharmacy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Services
{
    public class MedicineService
    : IMedicineService
    {

        private readonly IMedicineRepository _repository;



        public MedicineService(
        IMedicineRepository repository)
        {
            _repository = repository;
        }




        public async Task<List<MedicineDto>>
        GetAllAsync()
        {

            var medicines =
            await _repository.GetAllAsync();



            return medicines.Select(x =>

            new MedicineDto
            {

                Id = x.Id,


                FullName = x.FullName,


                Brand = x.Brand,


                ExpiryDate = x.ExpiryDate,


                Quantity = x.Quantity,


                Price = x.Price,


                IsExpiredSoon =
            x.IsExpiredSoon(),


                IsLowStock =
            x.IsLowStock()

            }).ToList();

        }





        public async Task CreateAsync(
        CreateMedicineDto dto)
        {

            var medicine =
            new Medicine
            {

                FullName = dto.FullName,


                Notes = dto.Notes,


                ExpiryDate = dto.ExpiryDate,


                Quantity = dto.Quantity,


                Price = dto.Price,


                Brand = dto.Brand

            };


            await _repository.AddAsync(medicine);


        }

    }
}
