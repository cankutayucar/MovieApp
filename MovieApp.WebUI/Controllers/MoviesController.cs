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

        public IActionResult List(int? id)
        {

            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var genreid = RouteData.Values["id"];
            

            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.GenreID == id).ToList();
            }
            var model = new MovieGenreViewModel()
            {
                Movies = movies
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
    }
}
