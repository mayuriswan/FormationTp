using Formation.Models;
using System.Collections.Generic;

namespace Formation.Services
{
    public interface IRestaurantService
    {
        Task<Restaurant> GetRestaurantAsync(string id);
        Task<List<Restaurant>> GetAllRestaurantsAsync();
        Task<Restaurant> AddRestaurantAsync(Restaurant restaurant);
        Task<Restaurant> UpdateRestaurantAsync(Restaurant newRestaurant);
        Task<Restaurant> DeleteRestaurantAsync(string id);
        //Task<Restaurant> GetRestaurantByNameAsync(string name);
    }
}
