using GoodFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFood.Data.Services
{
    public class GoodFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
