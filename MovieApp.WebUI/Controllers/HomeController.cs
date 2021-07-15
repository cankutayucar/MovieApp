using Microsoft.AspNetCore.Mvc;
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
            string filmBasligi = "Film Başlığı";
            string filmAciklama = "Film Açıklama";
            string filmYonetmen = "Film Yönetmen";
            string[] oyuncular = { "oyuncu 1", "oyuncu 2", "oyuncu 1", "oyuncu 2" };

            ViewBag.FilmBasligi = filmBasligi;
            ViewBag.FilmAciklama = filmAciklama;
            ViewBag.FilmYonetmen = filmYonetmen;
            ViewBag.Oyuncular = oyuncular;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
