using ABC.Pharmacy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {

        Task<User?> GetByEmailAsync(string email);


        Task AddAsync(User user);

    }
}
