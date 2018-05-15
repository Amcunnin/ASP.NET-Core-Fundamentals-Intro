using Microsoft.EntityFrameworkCore;
using Ode_To_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ode_To_Food.Data
{
    public class OdeToFoodDbContext : DbContext
    {

        public OdeToFoodDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
