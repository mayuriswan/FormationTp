using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormationApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
       
        public RestaurantController(IRestaurantService restaurantService)
        {

            _restaurantService = restaurantService;
            

        }
        // GET: RestaurantController$
        /// <summary>
        /// Get All Restaurants 
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public Task<List<Restaurant>> GetAll()
        {
            var restaurants = _restaurantService.GetAllRestaurantsAsync();
            return restaurants;
        }
        /// <summary>
        /// Retrieves a restaurant by ID.
        /// </summary>
        /// <param name = "id" > The ID of the restaurant to retrieve.</param>
        /// <param name = "opt" > An optional parameter that can be used to specify additional options.</param>
        /// <returns>A response that contains the restaurant, if it was found.</returns>
            [HttpGet("{id}")]
            public ActionResult GetById(string id, string opt = "")
        {
            var restaurant = _restaurantService.GetRestaurantAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant);
        }
        /// <summary>
        /// To Update A Restaurant 
        /// </summary>
        /// <param name="id">id of Restaurant Must be a STRING </param>
        /// <param name="restaurant"> The Body of the New Restaurant doesnt have to add </param>
        /// <returns></returns>
        [HttpPut("{id}")]

        public ActionResult UpdateRestaurant(string id, Restaurant restaurant)
        {
            var _restaurant = _restaurantService.GetRestaurantAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            _restaurant.Result.PhoneNumber = restaurant.PhoneNumber;
            _restaurant.Result.Address = restaurant.Address;
            _restaurant.Result.Name = restaurant.Name;
            return Ok(restaurant);
        }
        /// <summary>
        /// Delete  A Restaurant 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> returns NoContent si Restaurant N exsit pas</returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteRestaurant(string id)
        {
            var restaurant = _restaurantService.DeleteRestaurantAsync(id);

            if (restaurant == null)
            {
                return NoContent();
            }

            return Ok(restaurant);

        }
        /// <summary>
        /// Create a new restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant to create.</param>
        /// <returns>A response that contains the created restaurant.</returns>
        [HttpPost]
        public ActionResult CreateRestaurant([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest("Restaurant object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _restaurantService.AddRestaurantAsync(restaurant);
            return CreatedAtRoute("GetById", new { id = restaurant.Id }, restaurant);
        }

       
    }
}
