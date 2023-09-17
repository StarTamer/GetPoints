using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Interfaces
{
    public interface IAllJerseys
    {
        IEnumerable<Jersey> Jerseys { get; }
        IEnumerable<Jersey> getFavJerseys { get; }
        Jersey getObjectJersey(int carId);

    }
}
