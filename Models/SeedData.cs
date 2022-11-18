using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            if (context.Genre.Any())
            {
                return;   // DB has been seeded
            }
            context.Genre.AddRange(
                new Genre{GenreName = "Action"},
                new Genre{GenreName = "Comedy"},
                new Genre{GenreName = "Documentary"},
                new Genre{GenreName = "Drama"},
                new Genre{GenreName = "Western"}
            );
            context.SaveChanges();
        }
    }
}