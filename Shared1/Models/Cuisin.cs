using Formation.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace FormationMVC.Models.DTO
{
    public class Cuisin
    {
        public string Id { get; set; } 
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Country { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
