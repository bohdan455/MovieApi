using DBAccess.Model;
using MovieApi.DTO;

namespace MovieApi
{
    public static class Extensions
    {
        public static MovieModel ToMovieModel(this MovieDto dto)
        {
            return new MovieModel
            {
                Title = dto.Title,
                Description = dto.Description,
                Genre = dto.Genre,
                Released = dto.Released,
            };
        }
    }
}
