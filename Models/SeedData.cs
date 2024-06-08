using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Man on Fire",
                    ReleaseDate = DateTime.Parse("2009-8-21"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "King Kong",
                    ReleaseDate = DateTime.Parse("2005-7-21"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Dune: Part one",
                    ReleaseDate = DateTime.Parse("2023-11-3"),
                    Genre = "Sci-Fi",
                    Rating = "R",
                    Price = 15.99M
                },
                new Movie
                {
                    Title = "Captain Marvel",
                    ReleaseDate = DateTime.Parse("2023-11-10"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 15.99M
                },
                new Movie
                {
                    Title = "Dumb and Dumber",
                    ReleaseDate = DateTime.Parse("2002-12-16"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 15.99M
                }
            );
            context.SaveChanges();
        }
    }
}