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
    public class MedicineControllerTests
    {


        [Fact]

        public void Controller_Should_Create()
        {


            var service =
            new Mock<IMedicineService>();


            var controller =
            new MedicinesController(
            service.Object);



            Assert.NotNull(controller);


        }


    }
}
