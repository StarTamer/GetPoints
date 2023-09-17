using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.mocks
{
    public class MockCategory : IJerseysCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Без рукава", desc = "Модель джерси в виде майки без рукава"},
                    new Category{categoryName = "С рукавом", desc = "Модель джерси с рукавом"}
                };
            }
        }
    }
}
