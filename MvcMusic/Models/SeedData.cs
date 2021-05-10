using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMusic.Data;
using System;
using System.Linq;

namespace MvcMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMusicContext>>()))
            {
                // Look for any musics.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                    new Music
                    {
                        Title = "Cross",
                        Artist ="Justice",
                        ReleaseDate = DateTime.Parse("2007-6-11"),
                        Genre = "Electro",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Alive 2007",
                        Artist = "Daft Punk",
                        ReleaseDate = DateTime.Parse("2007-6-14"),
                        Genre = "House",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Queen",
                        Artist = "Queen",
                        ReleaseDate = DateTime.Parse("1973-7-13"),
                        Genre = "Rock",
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Liberté Chérie",
                        Artist = "Calogero",
                        ReleaseDate = DateTime.Parse("2017-8-25"),
                        Genre = "Pop, Rock",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}