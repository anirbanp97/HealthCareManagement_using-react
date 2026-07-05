using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.UnitTests.Services
{
    public class SaleServiceTests
    {


        [Fact]

        public async Task Sales_Should_Return_List()
        {


            var saleRepo =
            new Mock<ISaleRepository>();


            var medicineRepo =
            new Mock<IMedicineRepository>();



            var service =
            new SaleService(
            saleRepo.Object,
            medicineRepo.Object);



            var result =
            await service.GetSalesAsync();



            Assert.NotNull(result);


        }


    }
}
