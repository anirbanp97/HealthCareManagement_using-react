using ABC.Pharmacy.Application.DTOs.Auth;
using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Interfaces.Services;
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
    public class AuthServiceTests
    {

        private readonly Mock<IUserRepository> _userRepo;

        private readonly Mock<IJwtService> _jwtService;


        public AuthServiceTests()
        {
            _userRepo = new Mock<IUserRepository>();

            _jwtService = new Mock<IJwtService>();
        }



        [Fact]
        public async Task Login_Should_Return_Token()
        {

            var user = new User
            {
                Email = "admin@test.com",

                PasswordHash = "123456"
            };


            _userRepo.Setup(x =>
                x.GetByEmailAsync(user.Email))
                .ReturnsAsync(user);



            _jwtService.Setup(x =>
                x.GenerateToken(user))
                .Returns("token");



            var service =
            new AuthService(
                _userRepo.Object,
                _jwtService.Object);



            var result =
            await service.LoginAsync(
            new LoginRequestDto
            {
                Email = "admin@test.com",
                Password = "123456"
            });



            Assert.Equal(
                "token",
                result.Token);

        }

    }
}
