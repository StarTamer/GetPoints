using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.ViewModels
{
    public class JerseysListViewModel
    {
        public IEnumerable<Jersey> allJerseys { get; set; }
        public string currCategory { get; set; }
    }
}
