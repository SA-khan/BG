using BG.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Application.Interfaces
{
    public interface ICityService
    {
        IEnumerable<CityViewModel> GetCities();
    }
}
