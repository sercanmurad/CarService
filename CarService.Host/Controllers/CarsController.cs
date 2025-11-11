using CarService.BL.Interfaces;
using CarService.Models.DTL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarService.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        public ICarService CarService => _carService;

        [HttpGet]

        public IActionResult GetAllCars()
        {
            return Ok();
        }
    }
}
