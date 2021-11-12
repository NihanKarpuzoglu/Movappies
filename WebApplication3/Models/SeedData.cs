using Microsoft.EntityFrameworkCore;//
using Microsoft.Extensions.DependencyInjection;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;//

namespace WebApplication3.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication3Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication3Context>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1999-2-12"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating="9.4"
                    },

                    new Movie
                    {
                        Title = "Cars",
                        ReleaseDate = DateTime.Parse("2005-3-13"),
                        Genre = "Animation",
                        Price = 8.99M,
                        Rating="8.1"
                    },

                    new Movie
                    {
                        Title = "从结婚开始恋爱",
                        ReleaseDate = DateTime.Parse("2020-2-23"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating="7.8"
                    },

                    new Movie
                    {
                        Title = "Inception",
                        ReleaseDate = DateTime.Parse("2010-4-15"),
                        Genre = "Science Fiction",
                        Price = 3.99M,
                        Rating="9.0"
                    },
                    new Movie
                    {
                        Title="Shutter Island",
                        ReleaseDate=DateTime.Parse("2011-2-19"),
                        Genre="Thriller",
                        Price=5.95M,
                        Rating="8.9"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
