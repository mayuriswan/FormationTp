using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantService _restaurantService;

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public DetailsModel(IRestaurantService restaurantService)
        {
           _restaurantService = restaurantService;
        }
        public void OnGet()
        {
            Restaurant = _restaurantService.GetRestaurant(Request.Query["id"].ToString());
        }
    }
}
