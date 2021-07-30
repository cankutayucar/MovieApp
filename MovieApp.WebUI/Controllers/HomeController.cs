using Microsoft.AspNetCore.Mvc;
using MovieApp.WebUI.Data;
using MovieApp.WebUI.Entity;
using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;
        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopulerMovies = _context.Movies.ToList()
            };

            //string filmBasligi = "Film Başlığı";
            //string filmAciklama = "Film Açıklama";
            //string filmYonetmen = "Film Yönetmen";
            //string[] oyuncular = { "oyuncu 1", "oyuncu 2", "oyuncu 1", "oyuncu 2" };

            //var m = new Movie()
            //{
            //    Title = filmBasligi,
            //    Description = filmAciklama,
            //    Director = filmYonetmen,
            //    Players = oyuncular,
            //    ImageUrl = "ahmet1.jpg"
            //};

            //ViewBag.FilmBasligi = filmBasligi;
            //ViewBag.FilmAciklama = filmAciklama;
            //ViewBag.FilmYonetmen = filmYonetmen;
            //ViewBag.Oyuncular = oyuncular;

            return View(model);
        }

        public IActionResult About()
        {
            var turler = _context.Genres.ToList();

            return View(turler);
        }
    }
}
