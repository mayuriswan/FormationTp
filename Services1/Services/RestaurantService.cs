using Formation.Models;
using FormationMVC.Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Formation.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepository<Restaurant> _repository;

        public RestaurantService(IRepository<Restaurant> repository)
        {
            _repository = repository;
        }

        public async Task<Restaurant> GetRestaurantAsync(string id)
        {
           

            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Restaurant>> GetAllRestaurantsAsync()
        {
            return (await _repository.GetAllAsync()).ToList();
        }

        public async Task<Restaurant> AddRestaurantAsync(Restaurant restaurant)
        {
            await _repository.AddAsync(restaurant);
            await _repository.SaveChangesAsync();
            return restaurant;
        }

        public async Task<Restaurant> UpdateRestaurantAsync(Restaurant newRestaurant)
        {
            var oldRestaurant = await _repository.GetByIdAsync(newRestaurant.Id);

            if (oldRestaurant == null)
            {
                throw new ArgumentException("Restaurant not found.");
            }

            oldRestaurant.Name = newRestaurant.Name;
            oldRestaurant.Address = newRestaurant.Address;
            oldRestaurant.PhoneNumber = newRestaurant.PhoneNumber;

            _repository.Update(oldRestaurant);
            await _repository.SaveChangesAsync();

            return oldRestaurant;
        }

        public async Task<Restaurant> DeleteRestaurantAsync(string id)
        {
          

            var restaurant = await _repository.GetByIdAsync(id);

            if (restaurant == null)
            {
                throw new ArgumentException("Restaurant not found.");
            }

            _repository.Remove(restaurant);
            await _repository.SaveChangesAsync();

            return restaurant;
        }

        //public async Task<Restaurant> GetRestaurantByNameAsync(string name)
        //{
        //    return await _repository.FindAsync(r => r.Name == name);
        //}

    }
}

