using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantService _restaurantService;

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public EditModel(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public void OnGet()
        {
            Restaurant = _restaurantService.GetRestaurant(Request.Query["id"].ToString());

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {              
                return Page();
            }

            _restaurantService.UpdateRestaurant(Restaurant);
            return RedirectToPage("./Index");
        }
    }
}
