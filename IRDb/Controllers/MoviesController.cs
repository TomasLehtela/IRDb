using IRDb.Models;
using IRDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IRDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieModelsRepository _repo;

        public MoviesController(IMovieModelsRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            return _repo.GetAllMovies();
        }

        [HttpGet("{id}")]
        public MovieModel? Get(int id)
        {
            return _repo.GetMovieById(id);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] MovieModel movieToAdd)
        {
            _repo.PostMovieModel(movieToAdd);
        }

        [HttpPut("{id}")]
        public void Update(int id, MovieModel movieModel)
        {
            _repo.UpdateMovieModel(id, movieModel);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _repo.DeleteMovieModel(id);
        }
    }
}
