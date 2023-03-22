using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantService _restaurantService;

        public DeleteModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public IActionResult OnGet()
        {
            _restaurantService.DeleteRestaurant(Request.Query["id"].ToString());
            return RedirectToPage("/Index");

        }
    }
}
