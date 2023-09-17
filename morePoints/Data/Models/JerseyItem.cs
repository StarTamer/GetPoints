using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Models
{
    public class JerseyItem
    {
        public int id { get; set; }
        public Jersey jersey { get; set; }
        public int price { get; set; }
        public string JerseyViewId { get; set; }
    }
}
