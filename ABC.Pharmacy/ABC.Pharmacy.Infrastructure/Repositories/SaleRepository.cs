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
    public class SaleRepository
 : ISaleRepository
    {

        private readonly JsonDbContext _context;


        private const string FileName =
        "sales.json";



        public SaleRepository(
        JsonDbContext context)
        {

            _context = context;

        }



        public async Task AddAsync(
        Sale sale)
        {

            var list =
            await GetAllAsync();


            list.Add(sale);



            await _context
            .WriteAsync(
            FileName, list);

        }




        public async Task<List<Sale>>
        GetAllAsync()
        {

            return await _context
            .ReadAsync<Sale>(FileName);

        }


    }
}
