using CarService.Models.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataLayer.LocalDB
{
    internal static class StaticDB
    {
        public static List<Car> Cars = new List<Car>()
        {
             new Car() { Id=1, Model="Toyota Camry", Year=2020 },
             new Car() { Id=2, Model="Honda Accord", Year=2021 },
             new Car() { Id=3, Model="Ford Mustang", Year=2019 },
         };
    }
}
