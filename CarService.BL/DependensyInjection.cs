using CarService.DL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService.BL.Services;

namespace CarService.BL
{
    public static class DependensyInjection
    {
        public static IServiceCollection
            AddBusinessLayer(this IServiceCollection service)
        {
            service.AddSingleton<CarService, ICarServiceCrud>();
            return service;
        }
    }
}

