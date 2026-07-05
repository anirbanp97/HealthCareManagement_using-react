using ABC.Pharmacy.Application.DTOs.Auth;
using ABC.Pharmacy.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Pharmacy.API.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _service;


        public AuthController(
        IAuthService service)
        {
            _service = service;
        }



        [HttpPost("register")]
        public async Task<IActionResult>
        Register(RegisterRequestDto dto)
        {

            await _service.RegisterAsync(dto);


            return Ok("User Registered");

        }




        [HttpPost("login")]
        public async Task<IActionResult>
        Login(LoginRequestDto dto)
        {


            var result =
            await _service.LoginAsync(dto);


            return Ok(result);

        }



        [HttpPost("logout")]
        public IActionResult Logout()
        {

            return Ok(
            "Remove token from client");

        }


    }
}
