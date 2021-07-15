using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Controllers
{
    public class MoviesController : Controller
    {
        public string List()
        {
            return "movies list";
        }
        
        public string Details()
        {
            return "movies details";
        }
    }
}
