using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Interfaces
{
    public interface IJerseysCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
