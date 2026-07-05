using ABC.Pharmacy.Infrastructure.Persistence;
using ABC.Pharmacy.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.UnitTests.Repositories
{
    public class UserRepositoryTests
    {


        [Fact]

        public void Repository_Should_Create()
        {


            var context =
            new JsonDbContext();


            var repo =
            new UserRepository(context);



            Assert.NotNull(repo);


        }


    }
}
