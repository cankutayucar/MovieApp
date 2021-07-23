using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List(int? id, string q)
        {

            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var genreid = RouteData.Values["id"];
            var kelime = HttpContext.Request.Query["q"].ToString();

            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.GenreID == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
            }

            var model = new MovieGenreViewModel()
            {
                Movies = movies
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Turler = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }



        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var m = new Movie()
                {
                    Title = movie.Title,
                    Description = movie.Description,
                    Director = movie.Director,
                    ImageUrl = movie.ImageUrl,
                    GenreID = movie.GenreID
                };
                MovieRepository.Add(m);
                TempData["Message"] = $"{m.Title} isimli film eklendi";
                return RedirectToAction("List", "Movies");
            }
            ViewBag.Turler = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();

        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movies = MovieRepository.GetById(id);
            ViewBag.Turler = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(movies);
        }


        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(movie);
                return RedirectToAction("Details", "Movies", new { @id = movie.MovieId });
            }
            ViewBag.Turler = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(movie);
        }



        public IActionResult Delete(int MovieId, string Title)
        {
            MovieRepository.Delete(MovieId);
            TempData["Message"] = $"{Title} isimli film silindi";
            return RedirectToAction("List");
        }
    }
}
