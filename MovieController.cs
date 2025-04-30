using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022330080
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        public static List<string> actor1 = new List<string>
        {
            "Tim Robbins",
            "Morgan Freemon",
            "Bob Gunton",
        };
        private static List<string> actor2 = new List<string>
        {
            "Marlon Brando",
            "Al Pacino",
            "James Caon",
        };
        private static List<string> actor3 = new List<string>
        {
            "Heath Ledger",
            "Aaran Eckhart",
            "Michael Caine"
        };
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Daborant", actor1, "Two imprisoned men band over a number of years"),
            new Movie("The Godfather", "Francis Ford", actor2, "New York City"),
            new Movie("The Dark Knight", "Christoper Nolan", actor3, "Chaos people of Gthom")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieList;
        }

        [HttpGet("{index}")]
        public Movie GetByIndex(int index)
        {
            if (index < 0 || index >= movieList.Count)
            {
                return null;
            }
            return movieList[index];
        }

        [HttpPost]
        public void AddMovie([FromBody] Movie movie)
        {
            movieList.Add(movie);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            movieList.RemoveAt(index);
        }
    }
}
