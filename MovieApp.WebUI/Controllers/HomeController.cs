using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home index";
        }

        public string About()
        {
            return "home about";
        }
    }
}
