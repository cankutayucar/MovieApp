﻿using Microsoft.AspNetCore.Mvc;
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
            var filmListesi = new List<Movie>()
            {
                new Movie{Title="film 1",Description="açıklama 1",Director="yönetmen 1",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"}},

                new Movie{Title="film 2",Description="açıklama 2",Director="yönetmen 2",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"}},

                new Movie{Title="film 3",Description="açıklama 3",Director="yönetmen 3",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"}},

                new Movie{Title="film 4",Description="açıklama 4",Director="yönetmen 4",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"}},

                new Movie{Title="film 5",Description="açıklama 5",Director="yönetmen 5",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"}},
            };
            return View(filmListesi);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
