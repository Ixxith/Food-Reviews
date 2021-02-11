using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Reviews.Models
{

    // Class used to create and store top 5 restaurants
    public class Restaurant
    {
        // Constructor for setting up intial rank 
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        // Rank is read only after initialization
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        // Set default values for potential null values
        public string FavoriteDish { get; set; } = "It's all good!";
        [Required]
        public string Address { get; set; }
        [Phone]
        public string MobilePhone { get; set; } = "No phone number given";
        public string Website { get; set; } = "Coming soon";

        // Generate the top 5 resturants to be displayed when this method is called
        public static Restaurant[] GetRestaurants()
        {

            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Brick Oven Pizza",
                FavoriteDish = "Garlic Chicken Pizza",
                Address = "111 E 800 N, Provo, UT 84606",
                MobilePhone = "801-374-8800",
                Website = "https://www.brickovenrestaurants.com/"

            };

            Restaurant r2 = new Restaurant(2)
            {               
                RestaurantName = "Saigon Cafe",
                FavoriteDish = "Mongolian Beef",
                Address = "440 W 300 S, Provo, UT 84601",
                MobilePhone = "801-812-1173",
                Website = "http://saigoncafeprovo.biz/"

            };

            Restaurant r3 = new Restaurant(3)
            {                
                RestaurantName = "Mo'Bettahs",
                FavoriteDish = "Ekolu Special",
                Address = "442 900 E, Provo, UT 84606",
                MobilePhone = "801-784-6421",
                Website = "http://mobettahs.com/"

            };

            Restaurant r4 = new Restaurant(4)
            {               
                RestaurantName = "Wild Ginger",
                FavoriteDish = "Takamaki",
                Address = "366 N University Ave, Provo, UT 84601",
                MobilePhone = "801-691-1177",

            };

            Restaurant r5 = new Restaurant(5)
            {               
                RestaurantName = "Burger Supreme",
                Address = "1796 N University Pkwy, Provo, UT 84604",
                MobilePhone = "801-373-5713",
                Website = "http://burgerssupreme.com/"

            };
            // Return the 5 restaurants as an array
            return new Restaurant[] { r1,r2,r3,r4,r5 };
        }
    }
}
