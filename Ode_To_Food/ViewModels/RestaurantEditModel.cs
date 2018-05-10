using Ode_To_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ode_To_Food.ViewModels
{
    public class RestaurantEditModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
