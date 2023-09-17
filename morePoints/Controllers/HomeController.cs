using Microsoft.AspNetCore.Mvc;
using morePoints.Data.Interfaces;
using morePoints.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Controllers
{
    public class HomeController: Controller
    {
        private IAllJerseys _jerseyRep;

        public HomeController(IAllJerseys jerseyRep)
        {
            _jerseyRep = jerseyRep;
        }

        public ViewResult Index()
        {
            var homeJerseys = new HomeViewModel
            {
                favJerseys = _jerseyRep.getFavJerseys
            };
            return View(homeJerseys);
        }
    }
}
