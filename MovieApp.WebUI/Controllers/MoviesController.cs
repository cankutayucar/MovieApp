using Microsoft.AspNetCore.Mvc;
using MovieApp.WebUI.Data;
using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {

            var model = new MovieGenreViewModel()
            {
                Movies = MovieRepository.Movies
            };

            return View(model);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
