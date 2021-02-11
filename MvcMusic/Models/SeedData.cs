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
                        Title = "When Harry Met Sally OST",
                        Artist =" ",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "OST",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Ghostbusters OST",
                        Artist = " ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "OST",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Ghostbusters 2 OST",
                        Artist = " ",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "OST",
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Music
                    {
                        Title = "Rio Bravo OST",
                        Artist = " ",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "OST",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}