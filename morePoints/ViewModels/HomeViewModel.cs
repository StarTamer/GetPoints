using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Jersey> favJerseys { get; set; }
    }
}
