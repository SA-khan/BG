using BG.Domain.Models;
using BG.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Infra.Data.Repository
{
    public class CityRepository : ICityRepository
    {
        private BGDataContext _context;
        public CityRepository(BGDataContext ctx)
        {
            _context = ctx;
        }
        public IEnumerable<City> GetCities()
        {
            return _context.Cities;
        }
    }
}
