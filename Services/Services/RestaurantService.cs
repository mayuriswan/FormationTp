using Formation.Models;
using Formation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Formation.Services
{
    public class RestaurantService : IRestaurantService
    {
        List<Restaurant> restaurants =Repository.Repository.GetInstance().Restaurants;
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
 
            restaurant.Id= Guid.NewGuid().ToString();
            restaurants.Add(restaurant);
            return GetRestaurant(restaurant.Id);
        }


        public Restaurant GetRestaurant(string id) => restaurants.FirstOrDefault(r => r.Id == id);

        public List<Restaurant> getAllRestaurants()=> restaurants;

        
        public Restaurant UpdateRestaurant(Restaurant newRestaurant)
        {
            var restaurant = GetRestaurant(newRestaurant.Id);

            if (restaurant != null)
            {
                restaurant.Name = newRestaurant.Name;
                restaurant.Address = newRestaurant.Address;
                restaurant.PhoneNumber = newRestaurant.PhoneNumber;
            }
            return restaurant;
        }
        public Restaurant DeleteRestaurant(string id)
        {
            var restaurant = GetRestaurant(id);

            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }

            return restaurant;
        }
    }
}

