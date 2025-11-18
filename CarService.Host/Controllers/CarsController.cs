using CarService.BL.Interfaces;
using CarService.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarCrudServices _carService;

        public CarsController(ICarCrudServices carService)
        {
            _carService = carService;
        }

        [HttpGet(nameof(GetAllCars))]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Car data is null.");
            }
            _carService.AddCar(car);
            return Ok();
        }

        [HttpGet(nameof(GetById))]
        public IActionResult GetById(int id)
        {
            if(id <= 0)
            {
                return BadRequest("ID must be positive");
            }
            var car = _carService.GetById(id);
           
            if (car == null)
            {
                return BadRequest("Car not found!");
            }


            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar();
            return Ok();
        }
    }
}
