using Formation.Models;
using FormationMVC.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{

    public  class RestaurantDbContext : DbContext
    {
        public DbSet<Cuisin> Cuisines { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

                new DbInitializer(modelBuilder).Seed();
        }

    }
}
