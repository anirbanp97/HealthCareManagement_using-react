using ABC.Pharmacy.Infrastructure.Persistence;
using ABC.Pharmacy.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.UnitTests.Repositories
{
    public class SaleRepositoryTests
    {


        [Fact]

        public void Repository_Should_Create()
        {


            var repo =
            new SaleRepository(
            new JsonDbContext());



            Assert.NotNull(repo);


        }


    }
}
