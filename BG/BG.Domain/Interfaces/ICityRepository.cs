using BG.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Infra.Data
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities();
    }
}
