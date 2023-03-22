using Formation.Models;
using Formation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;
        public string stringCon=string.Empty;
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        private readonly IRestaurantService _restaurantService;
        public List<Restaurant> restaurants;

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration, IRestaurantService restaurantService)
        {
            _logger = logger;
            _configuration = configuration;
            stringCon = _configuration["ConnectionStrings"];
            _restaurantService = restaurantService;

            Console.WriteLine(stringCon);
        }
        public void OnGet()
        {
            restaurants = _restaurantService.getAllRestaurants();
        }
        public void OnPost()
        {
            
        }
    }
}

