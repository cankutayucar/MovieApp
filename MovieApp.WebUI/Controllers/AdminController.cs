using Microsoft.AspNetCore.Mvc;
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
        public IActionResult MovieUpdate(AdminEditMovieViewModel model, int[] genreId)
        {
            var entity = _context.Movies.Include(i => i.Genres).FirstOrDefault(i => i.MovieId == model.MovieId);

            if (entity == null)
            {
                return NotFound();
            }
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Genres = genreId.Select(i => _context.Genres.FirstOrDefault(a => a.GenreId == i)).ToList();
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }


        public IActionResult GenreList()
        {
            return View(new AdminGenresViewModel
            {
                Genres = _context.Genres.Select(i => new AdminGenreViewModel
                {
                    GenreId = i.GenreId,
                    Name = i.Name,
                    Count = i.Movies.Count
                }).ToList()
            });
        }


        public IActionResult GenreUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _context.Genres
                .Select(i => new AdminGenreEditViewModel
                {
                    GenreId = i.GenreId,
                    Name = i.Name,
                    Movies = i.Movies.Select(a => new AdminMovieViewModel
                    {
                        MovieId = a.MovieId,
                        Title = a.Title,
                        ImageUrl = a.ImageUrl
                    }).ToList()
                })
                .FirstOrDefault(i => i.GenreId == id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }


        [HttpPost]
        public IActionResult GenreUpdate(AdminGenreEditViewModel model, int[] movieIds)
        {
            var entity = _context.Genres.Include(i => i.Movies).FirstOrDefault(i => i.GenreId == model.GenreId);
            if (entity == null)
            {
                NotFound();
            }
            entity.Name = model.Name;
            foreach (var id in movieIds)
            {
                entity.Movies.Remove(entity.Movies.FirstOrDefault(i => i.MovieId == id));
            }
            _context.SaveChanges();
            return RedirectToAction("GenreList");
        }

    }
}
