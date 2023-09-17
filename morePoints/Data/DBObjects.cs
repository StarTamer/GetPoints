using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContext content)
        {                

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Jersey.Any())
            {
                content.AddRange(
                    new Jersey
                    {
                        Name = "GSW Curry #30",
                        shortDesc = "Джерси Golden State Warriors Stephen Curry",
                        longDesc = "",
                        img = "/img/curry.jpg",
                        price = 2499,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Без рукава"]
                    },
                    new Jersey
                    {
                        Name = "PTB Lillard #0",
                        shortDesc = "Джерси Portland Trail Blazers Damian Lillard",
                        longDesc = "",
                        img = "/img/lillard.jpg",
                        price = 2499,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Без рукава"]
                    },
                    new Jersey
                    {
                        Name = "LAL James #6",
                        shortDesc = "Джерси Los Angeles Lakers Lebron James",
                        longDesc = "",
                        img = "/img/james.png",
                        price = 2999,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Без рукава"]
                    },
                    new Jersey
                    {
                        Name = "CAVS Irving #2",
                        shortDesc = "Джерси Cleveland Cavaliers 2018 Kyrie Irving",
                        longDesc = "",
                        img = "/img/irving.jpg",
                        price = 3499,
                        isFavourite = true,
                        available = true,
                        Category = Categories["С рукавом"]
                    },
                    new Jersey
                    {
                        Name = "абоба",
                        shortDesc = "Джерси Абобы",
                        longDesc = "",
                        img = "/img/irving.jpg",
                        price = 9999,
                        isFavourite = false,
                        available = true,
                        Category = Categories["С рукавом"]
                    }
                    );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Без рукава", desc = "Модель джерси в виде майки без рукава"},
                        new Category{categoryName = "С рукавом", desc = "Модель джерси с рукавом"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
