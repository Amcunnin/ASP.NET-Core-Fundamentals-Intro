using Microsoft.AspNetCore.Mvc;
using Ode_To_Food.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ode_To_Food.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}
