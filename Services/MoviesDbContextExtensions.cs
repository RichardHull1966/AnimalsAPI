using System.Collections.Generic;
using System.Linq;
using MoviesAPI.Models;

namespace MoviesAPI.Services

{
     public static class MoviesDbContextExtensions
     {
          public static void CreateSeedData
               (this MoviesDbContext context)
          {
               if (context.Movies.Any())
                    return;
               var movies = new List<Movie>()
               {
                    new Movie()
                    {
                         Name = "Fred",
                         Year = 2018
                    },
                    new Movie()
                    {
                         Name = "Jim",
                         Year = 2017
                    },
                    new Movie()
                    {
                         Name = "Pete",
                         Year = 2018
                    }
               };
               context.AddRange(movies);
               context.SaveChanges();
          }
     }
}
