using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.mocks
{
    public class MockJerseys : IAllJerseys
    {
        private readonly IJerseysCategory _categoryJerseys = new MockCategory();
        public IEnumerable<Jersey> Jerseys
        {
            get {
                return new List<Jersey>
                    {
                    new Jersey{
                        Name = "GSW Curry #30", 
                        shortDesc="Джерси Golden State Warriors Stephen Curry", 
                        longDesc="", 
                        img="/img/curry.jpg", 
                        price = 2499, 
                        isFavourite= true, 
                        available = true, 
                        Category =  _categoryJerseys.AllCategories.First()
                    },
                    new Jersey{
                        Name = "PTB Lillard #0",
                        shortDesc="Джерси Portland Trail Blazers Damian Lillard",
                        longDesc="",
                        img="/img/lillard.jpg",
                        price = 2499,
                        isFavourite= true,
                        available = true,
                        Category =  _categoryJerseys.AllCategories.First()
                    },
                    new Jersey{
                        Name = "LAL James #6",
                        shortDesc="Джерси Los Angeles Lakers Lebron James",
                        longDesc="",
                        img="/img/james.png",
                        price = 2999,
                        isFavourite= true,
                        available = true,
                        Category =  _categoryJerseys.AllCategories.First()
                    },
                    new Jersey{
                        Name = "CAVS Irving #2",
                        shortDesc="Джерси Cleveland Cavaliers 2018 Kyrie Irving",
                        longDesc="",
                        img="/img/irving.jpg",
                        price = 3499,
                        isFavourite= true,
                        available = true,
                        Category =  _categoryJerseys.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<Jersey> getFavJerseys { get ; set ; }

        public Jersey getObjectJersey(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
