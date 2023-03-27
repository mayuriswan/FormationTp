using FormationMVC.Models.DTO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Formation.Models
{
    public class Restaurant
    {
       
        public string Id { get; set; }


        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Address field is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The PhoneNumber field is required.")]
        public string PhoneNumber { get; set; }
        public string CuisinId { get; set; }
        public List<Cuisin> Cuisines { get; set; }
        public string Description { get; set; }
    }
}
