using MovieApp.WebUI.Entity;
using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Name="Tur 1",GenreId=1},
                new Genre(){Name="Tur 2",GenreId=2},
                new Genre(){Name="Tur 3",GenreId=3},
                new Genre(){Name="Tur 4",GenreId=4},
                new Genre(){Name="Tur 5",GenreId=5},
                new Genre(){Name="Tur 6",GenreId=6},
                new Genre(){Name="Tur 7",GenreId=7},
                new Genre(){Name="Tur 8",GenreId=8}
            };
        }

        public static List<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }

        public static Genre GetById(int id)
        {
            return _genres.FirstOrDefault(i => i.GenreId == id);
        }

    }
}
