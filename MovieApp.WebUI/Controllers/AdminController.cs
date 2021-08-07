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
                .Include(i=>i.Genres)
                .Select(i=>new AdminMovieViewModel
                {
                    MovieId = i.MovieId,
                    Genres = i.Genres.ToList(),
                    ImageUrl = i.ImageUrl,
                    Title = i.Title
                })
                .ToList()
            });
        }
    }
}
