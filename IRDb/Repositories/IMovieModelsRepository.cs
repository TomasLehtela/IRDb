using IRDb.Models;

namespace IRDb.Repositories
{
    public interface IMovieModelsRepository
    {
        IEnumerable<MovieModel> GetAllMovies();
        MovieModel GetMovieById(int id);
        void PostMovieModel(MovieModel movieModel);
        void UpdateMovieModel(int id, MovieModel movieModel);
        void DeleteMovieModel(int id);
    }
}
