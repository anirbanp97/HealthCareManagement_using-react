using ABC.Pharmacy.Application.DTOs.Medicine;
using ABC.Pharmacy.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Pharmacy.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]

    public class MedicinesController
 : ControllerBase
    {

        private readonly IMedicineService _service;


        public MedicinesController(
        IMedicineService service)
        {

            _service = service;

        }



        [HttpGet]

        public async Task<IActionResult>
        Get()
        {

            return Ok(
            await _service.GetAllAsync());

        }




        [HttpPost]

        public async Task<IActionResult>
        Create(CreateMedicineDto dto)
        {

            await _service.CreateAsync(dto);


            return Ok();

        }


    }
}
