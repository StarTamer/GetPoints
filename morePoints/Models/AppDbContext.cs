using Microsoft.EntityFrameworkCore;
using morePoints.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace morePoints.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Jersey> Jersey { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<JerseyItem> JerseyItem { get; set; }
    }
}
