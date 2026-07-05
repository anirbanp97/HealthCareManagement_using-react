using ABC.Pharmacy.Application.DTOs.Sale;
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
    public class SaleService
: ISaleService
    {


        private readonly ISaleRepository _saleRepository;


        private readonly IMedicineRepository _medicineRepository;



        public SaleService(

        ISaleRepository saleRepository,

        IMedicineRepository medicineRepository)

        {

            _saleRepository = saleRepository;


            _medicineRepository = medicineRepository;

        }





        public async Task CreateSaleAsync(
        CreateSaleDto dto)
        {


            var medicine =
            await _medicineRepository
            .GetByIdAsync(dto.MedicineId);



            if (medicine == null)

                throw new Exception("Medicine not found");



            if (medicine.Quantity < dto.QuantitySold)

                throw new Exception("Stock unavailable");



            medicine.Quantity -= dto.QuantitySold;




            var sale = new Sale
            {

                MedicineId = medicine.Id,


                QuantitySold = dto.QuantitySold,


                UnitPrice = medicine.Price

            };



            await _saleRepository.AddAsync(sale);



            await _medicineRepository.UpdateAsync(medicine);


        }




        public async Task<List<SaleDto>>
        GetSalesAsync()
        {


            var sales =
            await _saleRepository.GetAllAsync();



            return sales.Select(x =>

            new SaleDto
            {

                Id = x.Id,


                MedicineId = x.MedicineId,


                QuantitySold = x.QuantitySold,


                TotalPrice = x.TotalPrice,


                SaleDate = x.SaleDate


            }).ToList();

        }


    }
}
