using BG.Application.Interfaces;
using BG.Application.Services;
using BG.Infra.Data;
using BG.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICityService, CityService>();

            //Infra.Data Layer
            services.AddScoped<ICityRepository, CityRepository>();
        }
    }
}
