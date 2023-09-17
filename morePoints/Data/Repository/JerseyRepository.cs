using Microsoft.EntityFrameworkCore;
using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Data.Repository
{
    public class JerseyRepository : IAllJerseys
    {
        private readonly AppDbContext appDBContent;

        public JerseyRepository(AppDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Jersey> Jerseys => appDBContent.Jersey.Include(c => c.Category);

        public IEnumerable<Jersey> getFavJerseys => appDBContent.Jersey.Where(p => p.isFavourite).Include(c => c.Category);

        public Jersey getObjectJersey(int jerseyId) => appDBContent.Jersey.FirstOrDefault(p => p.id == jerseyId);
    }
}
