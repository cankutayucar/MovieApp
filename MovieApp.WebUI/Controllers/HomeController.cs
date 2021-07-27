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
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopulerMovies = MovieRepository.Movies
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
            var turler = new List<Genre>()
            {
                new Genre(){Name="Tur 1"},
                new Genre(){Name="Tur 2"},
                new Genre(){Name="Tur 3"},
                new Genre(){Name="Tur 4"},
                new Genre(){Name="Tur 5"},
                new Genre(){Name="Tur 6"},
                new Genre(){Name="Tur 7"},
                new Genre(){Name="Tur 8"}
            };

            return View(turler);
        }
    }
}
