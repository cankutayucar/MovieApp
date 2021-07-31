using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();


            context.Database.Migrate();




            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(
                        new List<Movie>()
                {
                    new Movie{Title="film 1",Description="açıklama 1",ImageUrl="ahmet1.jpg",MovieId=1,GenreID=1},

                    new Movie{Title="film 2",Description="açıklama 2",ImageUrl="ahmet2.jpg",MovieId=2,GenreID=2},

                    new Movie{Title="film 3",Description="açıklama 3",ImageUrl="ahmet3.jpg",MovieId=3,GenreID=3},

                    new Movie{Title="film 4",Description="açıklama 4",ImageUrl="ahmet1.jpg",MovieId=4,GenreID=4},

                    new Movie{Title="film 5",Description="açıklama 5",ImageUrl="ahmet2.jpg",MovieId=5,GenreID=5}
                }
                        );
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(
                        new List<Genre>()
            {
                new Genre(){Name="Tur 1",GenreId=1},
                new Genre(){Name="Tur 2",GenreId=2},
                new Genre(){Name="Tur 3",GenreId=3},
                new Genre(){Name="Tur 4",GenreId=4},
                new Genre(){Name="Tur 5",GenreId=5},
                new Genre(){Name="Tur 6",GenreId=6},
                new Genre(){Name="Tur 7",GenreId=7},
                new Genre(){Name="Tur 8",GenreId=8}
            });
                }

                context.SaveChanges();
            }
        }
    }
}
