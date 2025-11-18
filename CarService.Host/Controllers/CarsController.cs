using CarService.BL.Interfaces;
using CarService.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CarService.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarCrudService _carCrudService;

        public CarsController(ICarCrudService carCrudService)
        {
            _carCrudService = carCrudService;
        }

        [HttpDelete]
        public IActionResult DeleteCar(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID must be greater than zero.");
            }
            var car = _carCrudService.GetById(id);
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found.");
            }
            _carCrudService.DeleteCar(id);
            return Ok();
        }

        [HttpGet(nameof(GetById))]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID must be greater than zero.");
            }

            var car = _carCrudService.GetById(id);
            
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found.");
            }

            return Ok(car);
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var cars = _carCrudService.GetAllCars();
            return Ok(cars);
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car? car)
        {
            if (car == null)
            {
                return BadRequest("Car data is null.");
            }

            _carCrudService.AddCar(car);

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCar(int id, [FromBody] Car? car)
        {
            if (id <= 0)
                return BadRequest("ID must be greater than zero.");

            if (id != car.Id)
                return BadRequest("ID in the route must match the ID in the car object.");

            var existingCar = _carCrudService.GetById(id);
            if (existingCar == null)
                return NotFound($"Car with ID {id} not found.");

            _carCrudService.UpdateCar(car);

            return NoContent(); // 204 No Content is the standard for successful PUT updates
        }
    }
}
