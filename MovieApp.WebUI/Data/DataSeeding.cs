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
                    new Movie{Title="film 1",Description="açıklama 1",ImageUrl="ahmet1.jpg",GenreID=1},

                    new Movie{Title="film 2",Description="açıklama 2",ImageUrl="ahmet2.jpg",GenreID=2},

                    new Movie{Title="film 3",Description="açıklama 3",ImageUrl="ahmet3.jpg",GenreID=3},

                    new Movie{Title="film 4",Description="açıklama 4",ImageUrl="ahmet1.jpg",GenreID=4},

                    new Movie{Title="film 5",Description="açıklama 5",ImageUrl="ahmet2.jpg",GenreID=5}
                }
                        );
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(
                        new List<Genre>()
            {
                new Genre(){Name="Tur 1"},
                new Genre(){Name="Tur 2"},
                new Genre(){Name="Tur 3"},
                new Genre(){Name="Tur 4"},
                new Genre(){Name="Tur 5"},
                new Genre(){Name="Tur 6"},
                new Genre(){Name="Tur 7"},
                new Genre(){Name="Tur 8"}
            });
                }

                context.SaveChanges();
            }
        }
    }
}
