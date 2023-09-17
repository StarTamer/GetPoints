using Microsoft.AspNetCore.Mvc;
using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using morePoints.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.ViewModels
{
    public class JerseysController : Controller
    {
        private readonly IAllJerseys _allJerseys;
        private readonly IJerseysCategory _allCategories;

        public JerseysController(IAllJerseys iAllJerseys, IJerseysCategory iJerseysCat)
        {
            _allJerseys = iAllJerseys;
            _allCategories = iJerseysCat;
        }
        [Route("Jerseys/List")]
        [Route("Jerseys/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Jersey> jerseys = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                jerseys = _allJerseys.Jerseys.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("rukav", category, StringComparison.OrdinalIgnoreCase))
                {
                    jerseys = _allJerseys.Jerseys.Where(i => i.Category.categoryName.Equals("С рукавом")).OrderBy(i => i.id);
                    currCategory = "С рукавом";
                }
                else if (string.Equals("notrukav", category, StringComparison.OrdinalIgnoreCase))
                {
                    jerseys = _allJerseys.Jerseys.Where(i => i.Category.categoryName.Equals("Без рукава")).OrderBy(i => i.id);
                    currCategory = "Без рукава";
                }

                

            }

            var jerObj = new JerseysListViewModel
            {
                allJerseys = jerseys,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с джерси";

            return View(jerObj);
        }
    }
}
