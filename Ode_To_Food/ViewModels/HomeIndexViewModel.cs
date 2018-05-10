using Ode_To_Food.Models;
using System.Collections.Generic;

namespace Ode_To_Food.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
