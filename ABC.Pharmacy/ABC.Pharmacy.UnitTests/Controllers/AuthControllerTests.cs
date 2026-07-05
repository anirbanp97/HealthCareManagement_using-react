using ABC.Pharmacy.API.Controllers;
using ABC.Pharmacy.Application.Interfaces.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.UnitTests.Controllers
{
    public class AuthControllerTests
    {


        [Fact]

        public void Controller_Should_Create()
        {


            var service =
            new Mock<IAuthService>();


            var controller =
            new AuthController(
            service.Object);



            Assert.NotNull(controller);


        }


    }
}
