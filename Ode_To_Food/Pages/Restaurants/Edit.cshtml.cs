using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ode_To_Food.Models;
using Ode_To_Food.Services;

namespace Ode_To_Food.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restarantData)
        {
            _restaurantData = restarantData;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);
            if(Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { id = Restaurant.Id });
            }
            return Page();
        }
    }
}