using DBAccess.Access;
using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Data
{
    public class MovieData : IMovieData
    {
        private readonly ISqlDataAccess _db;
        public MovieData(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<IEnumerable<MovieModel>> GetAllMovies() =>
            await _db.LoadData<MovieModel, dynamic>("spMovie_GetAllMovies", new { });
        public async Task<MovieModel> GetMovie(int id)
        {
            var result = await _db.LoadData<MovieModel, dynamic>("spMovie_GetMovie", new { Id = id });
            return result.FirstOrDefault();
        }
        public async Task UpdateMovie(MovieModel movie) => await _db.PostData("spMovie_UpdateMovie", movie);
        public async Task InsertMovie(MovieModel movie) => await _db.PostData("spMovie_InsertMovie", new { movie.Title, movie.Released, movie.Description, movie.Genre });
    }
}
