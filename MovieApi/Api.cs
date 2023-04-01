using DBAccess.Data;
using DBAccess.Model;
using Microsoft.AspNetCore.Builder;
using MovieApi.DTO;

namespace MovieApi
{
    public static class Api
    {
        public static void UseApiConfiguration(this WebApplication app)
        {
            app.MapGet("/Movies", getAllMovies);
            app.MapGet("/Movies/{id}", getMovie);
            app.MapPost("/Movies", insertMovie);
            app.MapPut("/Movies",updateMovie);
        }
        private static async Task<IResult> getAllMovies(IMovieData movieData)
        {
            try
            {
                return Results.Ok(await movieData.GetAllMovies());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> getMovie(IMovieData movieData, int id)
        {
            try
            {
                var result = await movieData.GetMovie(id);

                if (result is null)
                    return Results.NotFound();

                return Results.Ok(result);
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> insertMovie(IMovieData movieData, MovieDto movie)
        {
            try
            {
                await movieData.InsertMovie(movie.ToMovieModel());
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> updateMovie(IMovieData movieData, MovieModel movie)
        {
            try
            {
                await movieData.UpdateMovie(movie);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
