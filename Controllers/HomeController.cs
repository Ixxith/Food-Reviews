using Food_Reviews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Reviews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        // Returns the index page
        public IActionResult Index()
        {

              // Includes the Top 5 resturants using the GetResturants method that is
              // apart of the Restaurant class
            return View(Restaurant.GetRestaurants());
        }

        // When performing a Get, show suggestion page
        [HttpGet("Submit")]
        public IActionResult SubmitSuggestion()
        {
            return View();
        }

        // When performing a Post, process suggestion submitted
        [HttpPost("Submit")]
        public IActionResult SubmitSuggestion(Suggestion suggestion)
        {
            // Check that model state is valid
            if (ModelState.IsValid)
            {
               
                // If valid, check and set empty non-required values,add suggestion to the TempStorage, and show the home page.
                if (String.IsNullOrEmpty(suggestion.FavoriteDish))
                {
                    suggestion.FavoriteDish = "It's all good!";
                }
                if (String.IsNullOrEmpty(suggestion.MobilePhone))
                {
                    suggestion.MobilePhone = "No phone number given";
                }
                TempStorage.AddSuggestion(suggestion);
                return RedirectToAction("Index");
            }
            // Otherwise, stay on the same page
            return View();
        }

        [HttpGet("View")]
        // Go to the ViewSuggestions page and show what suggestions are saved in TempStorage
        public IActionResult ViewSuggestions()
        {
            return View(TempStorage.Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
