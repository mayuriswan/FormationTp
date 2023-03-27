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
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }




        public void Seed()
        {
            SeedCuisines();
            SeedRestaurants();
        }

        private void SeedCuisines()
        {
            modelBuilder.Entity<Cuisin>().HasData(
                new Cuisin
                {
                    Id = "1",
                    Name = "Italian",
                    Description = "Traditional Italian dishes",
                    Country = "Italy"
                },
                new Cuisin
                {
                    Id = "2",
                    Name = "French",
                    Description = "French cuisine with a modern twist",
                    Country = "France"
                },
                new Cuisin
                {
                    Id = "3",
                    Name = "Japanese",
                    Description = "Fresh sushi and sashimi",
                    Country = "Japan"
                }
            );
        }

        private void SeedRestaurants()
        {
            modelBuilder.Entity<Restaurant>().HasData(
               
                new Restaurant
                {
                    Id = "2",
                    Name = "French Bistro",
                    Address = "456 Second St",
                    PhoneNumber = "0698765432",
                    Description = "A classic French bistro",
                    CuisinId = "2"
                },
                new Restaurant
                {
                    Id = "3",
                    Name = "Sushi Bar",
                    Address = "789 Third St",
                    PhoneNumber = "0601234567",
                    Description = "A trendy Japanese sushi bar",
                    CuisinId = "3"
                }
            );
        }


    }




}
