using BG.Application.Interfaces;
using BG.Application.ViewModels;
using BG.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Application.Services
{
    public class CityService : ICityService
    {
        private ICityRepository _context;
        public CityService(ICityRepository ctx)
        {
            _context = ctx;
        }
        public CityViewModel GetCities()
        {
            return new CityViewModel
            {
                Cities = _context.GetCities()
            };
        }
    }
}
