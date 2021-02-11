using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Suggestion Class, used to save the suggestions made by users of Restaurants
// These suggestions are saved in the TempStorage class

namespace Food_Reviews.Models
{
    public class Suggestion
    {
        // Each field has a default value to prevent exceptions when null values occur
        [Required]
        public string Name { get; set; } = "No name given";
        [Required]
        public string RestaurantName { get; set; } = "No name given";
        public string FavoriteDish { get; set; } = "It's all good!";
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string MobilePhone { get; set; } = "No phone number given";
       
    }
}
