using CarService.DataLayer.LocalDB;
using CarService.Models.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataLayer.Repository
{
    internal class CarLocalRepository : Interface
    {
        public void AddCar(Car car)
        {
            StaticDB.Cars.Add(car);
        }

        public void DeleteCar(int  id)
        {
            StaticDB.Cars.RemoveAll(match:Car =>Car.Id == id);
        }

        public List <Car> GetAllCars()
        {
            return StaticDB.Cars;
        }
    }
}
