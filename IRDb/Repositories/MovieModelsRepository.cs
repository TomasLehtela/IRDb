using IRDb.Database;
using IRDb.Models;

namespace IRDb.Repositories
{
    public class MovieModelsRepository : IMovieModelsRepository
    {
        private readonly AppDbContext _context;

        public MovieModelsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieModel> GetAllMovies()
        {
            return _context.MovieModels;
        }

        public MovieModel GetMovieById(int id)
        {
            MovieModel? movie = _context.MovieModels.FirstOrDefault(m => m.Id == id);

            if (movie != null)
            {
                return movie;
            }
            else
            {
                throw new ArgumentException("Movie not found");
            }
        }

        public void PostMovieModel(MovieModel movieModel)
        {
            _context.MovieModels.Add(movieModel);
            _context.SaveChanges();
        }

        public void UpdateMovieModel(int id, MovieModel movieModel)
        {
            MovieModel? movieToUpdate = _context.MovieModels.FirstOrDefault(m => m.Id == id);

            if (movieToUpdate != null)
            {
                movieToUpdate.Title = movieModel.Title;
                movieToUpdate.Director = movieModel.Director;
                movieToUpdate.Year = movieModel.Year;
                movieToUpdate.Genre = movieModel.Genre;
                movieToUpdate.Duration = movieModel.Duration;
                movieToUpdate.Rating = movieModel.Rating;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Movie not found");
            }
        }

        public void DeleteMovieModel(int id)
        {
            MovieModel? movieToDelete = _context.MovieModels.FirstOrDefault(m => m.Id == id);

            if (movieToDelete != null)
            {
                _context.MovieModels.Remove(movieToDelete);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Movie not found");
            }
        }
    }
}
