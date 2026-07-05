using ABC.Pharmacy.Application.DTOs.Auth;
using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Interfaces.Services;
using ABC.Pharmacy.Domain.Entities;
using ABC.Pharmacy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Services
{
    public class AuthService : IAuthService
    {

        private readonly IUserRepository _userRepository;


        private readonly IJwtService _jwtService;


        public AuthService(
            IUserRepository userRepository,
            IJwtService jwtService)
        {
            _userRepository = userRepository;

            _jwtService = jwtService;
        }



        public async Task RegisterAsync(
            RegisterRequestDto request)
        {

            var existingUser =
                await _userRepository
                .GetByEmailAsync(request.Email);



            if (existingUser != null)
            {
                throw new Exception(
                    "User already exists");
            }



            var user = new User
            {
                FullName = request.FullName,

                Email = request.Email,

                PasswordHash = request.Password,

                Role = UserRole.User
            };


            await _userRepository
            .AddAsync(user);

        }





        public async Task<AuthResponseDto> LoginAsync(
            LoginRequestDto request)
        {


            var user =
                await _userRepository
                .GetByEmailAsync(request.Email);



            if (user == null)
            {
                throw new Exception(
                "Invalid login");
            }



            if (user.PasswordHash != request.Password)
            {
                throw new Exception(
                "Invalid password");
            }



            var token =
                _jwtService.GenerateToken(user);



            return new AuthResponseDto
            {
                Token = token,

                ExpireAt =
                DateTime.UtcNow.AddHours(1)
            };

        }

    }
}
