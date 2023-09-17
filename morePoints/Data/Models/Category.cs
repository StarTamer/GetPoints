using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string desc { get; set; }

        public List<Jersey> jerseys { get; set; }
    }
}
