using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Services;
using ABC.Pharmacy.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.UnitTests.Services
{
    public class MedicineServiceTests
    {

        [Fact]

        public async Task GetAll_Should_Return_Medicines()
        {


            var repo =
            new Mock<IMedicineRepository>();


            repo.Setup(x => x.GetAllAsync())
            .ReturnsAsync(
            new List<Medicine>
            {

new Medicine
{
FullName="Paracetamol",
Quantity=10
}

            });



            var service =
            new MedicineService(repo.Object);



            var result =
            await service.GetAllAsync();



            Assert.Single(result);


        }

    }
}
