using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMusic.Data;
using MvcMusic.Models;

namespace MvcMusic.Controllers
{
    [Route("api/Music")]
    [ApiController]
    public class APIMusic : ControllerBase
    {
        private readonly MvcMusicContext _context;

        public APIMusic(MvcMusicContext context)
        {
            _context = context;
        }

        // GET: api/APIMusic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicDTO>>> GetMusic()
        {
            return await _context.Music
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        // GET: api/APIMusic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Music>> GetMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);

            if (music == null)
            {
                return NotFound();
            }

            return CreatedAtAction(
                    nameof(GetMusic),
                    new { id = music.Id },
                    ItemToDTO(music));
        }

        // PUT: api/APIMusic/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusic(int id, MusicDTO musicDTO)
        {
            /* if (id != MusicDTO.Id)
             {
                 return BadRequest();
             }

             _context.Entry(music).State = EntityState.Modified;

             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!MusicExists(id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }
             }

             return NoContent();*/

            if (id != musicDTO.Id)
            {
                return BadRequest();
            }

            var todoItem = await _context.Music.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            todoItem.Title = musicDTO.Title;
            todoItem.Artist = musicDTO.Artist;
            todoItem.ReleaseDate = musicDTO.ReleaseDate;
            todoItem.Genre = musicDTO.Genre;
            todoItem.Price = musicDTO.Price;
            todoItem.Rating = musicDTO.Rating;
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!MusicExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/APIMusic
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Music>> PostMusic(MusicDTO musicDTO)
        {
            /*_context.Music.Add(musicDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMusic), new { id = musicDTO.Id }, musicDTO);*/

            
                var music = new Music
                {
                    Title = musicDTO.Title,
                    Artist = musicDTO.Artist,
                    ReleaseDate = musicDTO.ReleaseDate,
                    Genre = musicDTO.Genre,
                    Price = musicDTO.Price,
                    Rating = musicDTO.Rating,
                };

                _context.Music.Add(music);
                await _context.SaveChangesAsync();

                return CreatedAtAction(
                    nameof(GetMusic),
                    new { id = music.Id },
                    ItemToDTO(music));
            
        }

        // DELETE: api/APIMusic/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);
            if (music == null)
            {
                return NotFound();
            }

            _context.Music.Remove(music);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicExists(int id)
        {
            return _context.Music.Any(e => e.Id == id);
        }

        private static MusicDTO ItemToDTO(Music music) =>
    new MusicDTO
    {
        Id = music.Id,
        Title = music.Title,
        Artist = music.Artist,
        ReleaseDate = music.ReleaseDate,
        Genre = music.Genre,
        Price = music.Price,
        Rating = music.Rating

    };
    }
}
