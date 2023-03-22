using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class AddRestaurantModel : PageModel
    {
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        private readonly IRestaurantService _restaurantService;
        public List<Restaurant> restaurants;

        public AddRestaurantModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                // If the model state is invalid, redisplay the form with validation errors.
                return Page();
            }
            //restaurants = _restaurantService.getAllRestaurants();
            _restaurantService.AddRestaurant(Restaurant);
            return RedirectToPage("./Index");

        }
    }
}
