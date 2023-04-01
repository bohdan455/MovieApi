using DBAccess.Model;

namespace DBAccess.Data
{
    public interface IMovieData
    {
        Task<IEnumerable<MovieModel>> GetAllMovies();
        Task<MovieModel> GetMovie(int id);
        Task InsertMovie(MovieModel movie);
        Task UpdateMovie(MovieModel movie);
    }
}