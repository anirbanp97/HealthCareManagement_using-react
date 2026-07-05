using ABC.Pharmacy.Application.DTOs.Sale;
using ABC.Pharmacy.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Pharmacy.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]


    public class SalesController
: ControllerBase
    {

        private readonly ISaleService _service;


        public SalesController(
        ISaleService service)
        {

            _service = service;

        }



        [HttpPost]

        public async Task<IActionResult>
        Create(CreateSaleDto dto)
        {

            await _service.CreateSaleAsync(dto);


            return Ok();

        }



        [HttpGet]

        public async Task<IActionResult>
        Get()
        {

            return Ok(
            await _service.GetSalesAsync());

        }


    }
}
