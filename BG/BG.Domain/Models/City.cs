using System;
using System.Collections.Generic;
using System.Text;

namespace BG.Domain.Models
{
   public class City
    {
        public long CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
