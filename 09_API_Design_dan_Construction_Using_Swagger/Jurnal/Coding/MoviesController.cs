using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul9_2211104017.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                Description = "Two imprisoned men bond over a number of years..."
            },
            new Movie {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                Description = "The aging patriarch of an organized crime dynasty..."
            },
            new Movie {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                Description = "When the menace known as the Joker wreaks havoc..."
            }
        };

        // GET: api/Movies
        [HttpGet]
        public ActionResult<List<Movie>> Get() => movies;

        // GET: api/Movies/{id}
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();
            return movies[id];
        }

        // POST: api/Movies
        [HttpPost]
        public ActionResult<List<Movie>> Post([FromBody] Movie newMovie)
        {
            movies.Add(newMovie);
            return movies;
        }

        // DELETE: api/Movies/{id}
        [HttpDelete("{id}")]
        public ActionResult<List<Movie>> Delete(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();
            movies.RemoveAt(id);
            return movies;
        }
    }
}
