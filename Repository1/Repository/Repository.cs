using Formation.Models;
using FormationMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace FormationMVC.Repository
{
    public class Repository
    {
        public static Repository _instance;
        private Repository()
        {

        }
        
            public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>
                 {
        new Restaurant
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Resto 1",
            Address = "Rabat Hay Ryad",
            PhoneNumber = "09999889",
            Cuisines = new List<Cuisin>
            {
                new Cuisin { Name = "French", Description = "French cuisine", Country = "France" },
                new Cuisin { Name = "Italian", Description = "Italian cuisine", Country = "Italy" }
            }
        },
        new Restaurant
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Resto 2",
            Address = "Rabat Hay MANAL",
            PhoneNumber = "5555899",
            Cuisines = new List<Cuisin>
            {
                new Cuisin { Name = "Japanese", Description = "Japanese cuisine", Country = "Japan" },
                new Cuisin { Name = "Mexican", Description = "Mexican cuisine", Country = "Mexico" }
            }
        },
        new Restaurant
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Resto 3",
            Address = "Rabat Hay FATH",
            PhoneNumber = "56255",
            Cuisines = new List<Cuisin>
            {
                new Cuisin { Name = "Chinese", Description = "Chinese cuisine", Country = "China" },
                new Cuisin { Name = "Indian", Description = "Indian cuisine", Country = "India" }
            }
        }
    };
        

        public List<Cuisin> Cuisins { get; set; } = new List<Cuisin>()
        {
            new Cuisin { Name = "French", Description = "French cuisine", Country = "France" },
        new Cuisin { Name = "Italian", Description = "Italian cuisine", Country = "Italy" },
        new Cuisin { Name = "Japanese", Description = "Japanese cuisine", Country = "Japan" },
        new Cuisin { Name = "Mexican", Description = "Mexican cuisine", Country = "Mexico" }
        };
        public static Repository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Repository();
            }
            return _instance;
        }
    }
}
