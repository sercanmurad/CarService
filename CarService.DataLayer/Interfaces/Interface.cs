using CarService.Models.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataLayer.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(Car car);
        void AddCar(CarService.BL.Interfaces.Car car);
        void AddCar(CarService.BL.Interfaces.Car car);
        void AddCar(CarService.BL.Interfaces.Car car);
        void AddCar(CarService.BL.Interfaces.Car car);
        void DeleteCar(int id);

        List<Car> GetAllCars();
    }
}
