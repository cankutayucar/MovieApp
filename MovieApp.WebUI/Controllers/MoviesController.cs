using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp.WebUI.Data;
using MovieApp.WebUI.Entity;
using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
        }

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

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();

            if (id != null)
            {
                movies = movies.Include(i => i.Genres).Where(i => i.Genres.Any(i => i.GenreId == id));
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower()));
            }

            var model = new MovieGenreViewModel()
            {
                Movies = movies.ToList()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Turler = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();
        }



        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //var m = new Movie()
                //{
                //    Title = movie.Title,
                //    Description = movie.Description,
                //    Director = movie.Director,
                //    ImageUrl = movie.ImageUrl,
                //    GenreID = movie.GenreID
                //};
                //MovieRepository.Add(m);

                _context.Movies.Add(movie);
                _context.SaveChanges();

                TempData["Message"] = $"{movie.Title} isimli film eklendi";
                return RedirectToAction("List", "Movies");
            }
            ViewBag.Turler = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();

        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movies = _context.Movies.Find(id);
            ViewBag.Turler = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(movies);
        }


        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //MovieRepository.Edit(movie);
                _context.Movies.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("Details", "Movies", new { @id = movie.MovieId });
            }
            ViewBag.Turler = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(movie);
        }



        public IActionResult Delete(int MovieId, string Title)
        {
            //MovieRepository.Delete(MovieId);
            var entity = _context.Movies.Find(MovieId);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            TempData["Message"] = $"{Title} isimli film silindi";
            return RedirectToAction("List");
        }
    }
}
