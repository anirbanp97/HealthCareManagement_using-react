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
    public class UserRepository
     : IUserRepository
    {


        private readonly JsonDbContext _context;


        private const string FileName = "users.json";



        public UserRepository(
        JsonDbContext context)
        {

            _context = context;

        }





        public async Task<User?> GetByEmailAsync(
        string email)
        {


            var users =
            await _context
            .ReadAsync<User>(FileName);



            return users.FirstOrDefault(
            x => x.Email == email);

        }






        public async Task AddAsync(
        User user)
        {


            var users =
            await _context
            .ReadAsync<User>(FileName);



            users.Add(user);



            await _context
            .WriteAsync(
            FileName,
            users);


        }


    }
}
