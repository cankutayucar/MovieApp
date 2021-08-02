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


            var genres = new List<Genre>()
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
            var movies = new List<Movie>()
                {
                    new Movie{Title="film 1",Description="açıklama 1",ImageUrl="ahmet1.jpg",GenreId=genres[0].GenreId,Genre=genres[0]},

                    new Movie{Title="film 2",Description="açıklama 2",ImageUrl="ahmet2.jpg",GenreId=genres[1].GenreId,Genre=genres[1]},

                    new Movie{Title="film 3",Description="açıklama 3",ImageUrl="ahmet3.jpg",GenreId=genres[2].GenreId,Genre=genres[2]},

                    new Movie{Title="film 4",Description="açıklama 4",ImageUrl="ahmet1.jpg",GenreId=genres[3].GenreId,Genre=genres[3]},

                    new Movie{Title="film 5",Description="açıklama 5",ImageUrl="ahmet2.jpg",GenreId=genres[4].GenreId,Genre=genres[4]}
                };
            var users = new List<User>()
            {
                new User(){ UserName="user 1", Mail="user 1 mail", Password ="1234",ImageUrl="ahmet1.jpg"},
                new User(){ UserName="user 2", Mail="user 2 mail", Password ="12345",ImageUrl="ahmet2.jpg"},
                new User(){ UserName="user 3", Mail="user 3 mail", Password ="123456",ImageUrl="ahmet3.jpg"},
                new User(){ UserName="user 4", Mail="user 4 mail", Password ="1234567",ImageUrl="ahmet1.jpg"},
                new User(){ UserName="user 5", Mail="user 5 mail", Password ="12345678",ImageUrl="ahmet2.jpg"},
                new User(){ UserName="user 6", Mail="user 6 mail", Password ="123456789",ImageUrl="ahmet3.jpg"}
            };
            var people = new List<Person>()
            {
                    new Person()
                    {
                        Name = "Personel 1",
                        Biography = "biography 1",
                        User = users[0]
                    },
                    new Person()
                    {
                        Name = "Personel 2",
                        Biography = "biography 2",
                        User = users[1]
                    }
            };
            var crews = new List<Crew>()
            {
                new Crew(){Movie=movies[0],Person=people[0],Job="Yönetmen"},
                new Crew(){Movie=movies[0],Person=people[1],Job="Yönetmen Yardımcısı"}
            };
            var cast = new List<Cast>()
            {
                new Cast(){Movie=movies[0],Person=people[0],Name="Oyuncu Adı 1",Character="Karakter 1"},
                new Cast(){Movie=movies[0],Person=people[1],Name="Oyuncu Adı 2",Character="Karakter 2"}
            };



            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);
                }
                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(users);
                }
                if (context.People.Count() == 0)
                {
                    context.People.AddRange(people);
                }
                if (context.Casts.Count() == 0)
                {
                    context.Casts.AddRange(cast);
                }
                if (context.Crews.Count() == 0)
                {
                    context.Crews.AddRange(crews);
                }
                context.SaveChanges();
            }
        }
    }
}
