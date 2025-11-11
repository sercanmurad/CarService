using CarService.BL.Interfaces;
using CarService.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.BL.Services
{
    internal class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService() 
        {
            
        }

        public ICarRepository CarRepository => _carRepository;

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository?.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            _carRepository.GetAllCars();
        }
    }
}
