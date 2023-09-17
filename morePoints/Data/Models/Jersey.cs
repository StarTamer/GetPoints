using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Models
{
    public class Jersey
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string Name { get; set; }

        public string shortDesc { get; set; }

        public string longDesc { get; set; }

        public string img { get; set; }

        public ushort price { get; set; }

        public bool isFavourite { get; set; }

        public bool available { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
