using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Repository
{
    public class CategoryRepository : IJerseysCategory
    {
        private readonly AppDbContext appDBContent;
        public CategoryRepository(AppDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
