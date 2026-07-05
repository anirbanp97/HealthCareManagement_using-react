using ABC.Pharmacy.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Interfaces.Services
{
    public interface IAuthService
    {

        Task<AuthResponseDto> LoginAsync(
        LoginRequestDto request);


        Task RegisterAsync(
        RegisterRequestDto request);

    }
}
