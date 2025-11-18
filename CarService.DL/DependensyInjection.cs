using CarService.DL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DL
{
    public static class DependensyInjection
    {
        public static IServiceCollection
            AddDataLayer(this IServiceCollection service)
        {
            service.AddSingleton<ICarRepository, Repositories.CarLocalRepository>();
            return service;
        }
    }

    public interface IServiceCollection
    {
    }
}
