using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.WebUI.Data;
using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly MovieContext _context;
        public AdminController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult MovieList()
        {
            return View(new AdminMoviesViewModel()
            {
                Movies = _context.Movies
                .Include(i => i.Genres)
                .Select(i => new AdminMovieViewModel
                {
                    MovieId = i.MovieId,
                    Genres = i.Genres.ToList(),
                    ImageUrl = i.ImageUrl,
                    Title = i.Title
                })
                .ToList()
            });
        }

        public IActionResult MovieUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _context.Movies.Select(i => new AdminEditMovieViewModel
            {
                MovieId = i.MovieId,
                Title = i.Title,
                Description = i.Description,
                ImageUrl = i.ImageUrl,
                SelectedGenres = i.Genres
            }).FirstOrDefault(i => i.MovieId == id);

            ViewBag.Genres = _context.Genres.ToList();


            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);

        }

        [HttpPost]
        public IActionResult MovieUpdate(AdminEditMovieViewModel model)
        {
            var entity = _context.Movies.Find(model.MovieId);

            if (entity == null)
            {
                return NotFound();
            }
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
