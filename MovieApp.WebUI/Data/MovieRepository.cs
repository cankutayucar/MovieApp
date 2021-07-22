using MovieApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie{Title="film 1",Description="açıklama 1",Director="yönetmen 1",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"},ImageUrl="ahmet1.jpg",MovieId=1,GenreID=1},

                new Movie{Title="film 2",Description="açıklama 2",Director="yönetmen 2",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"},ImageUrl="ahmet2.jpg",MovieId=2,GenreID=2},

                new Movie{Title="film 3",Description="açıklama 3",Director="yönetmen 3",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"},ImageUrl="ahmet3.jpg",MovieId=3,GenreID=3},

                new Movie{Title="film 4",Description="açıklama 4",Director="yönetmen 4",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"},ImageUrl="ahmet1.jpg",MovieId=4,GenreID=4},

                new Movie{Title="film 5",Description="açıklama 5",Director="yönetmen 5",Players=new string[]{"oyuncu 1","oyuncu 2", "oyuncu 3","oyuncu 4","oyuncu 5","oyuncu 6","oyuncu 7"},ImageUrl="ahmet2.jpg",MovieId=5,GenreID=5}
            };
        }



        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.MovieId == id);
        }

        public static void Edit(Movie m)
        {
            foreach (var item in _movies)
            {
                if (item.MovieId == m.MovieId)
                {
                    item.Title = m.Title;
                    item.Description = m.Description;
                    item.Director = m.Director;
                    item.ImageUrl = m.ImageUrl;
                    item.GenreID = m.GenreID;
                    break;
                }
            }
        }
    }
}
