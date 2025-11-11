using CarService.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.BL.Interfaces
{
    public interface ICarService
    {
        void AddCar(Car car);

        void DeleteCar(int id);

        List<Car> GetAllCars();
    }
}
