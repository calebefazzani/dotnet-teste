using System.Collections.Generic;
using System.Threading.Tasks;
using Movie.Core.Models;

namespace Movie.Core.Services 
{
    public interface IMovieService 
    {
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie newMovie);
        Task UpdateMovie(Movie movieToUpdate, Movie movie);
        Task DeleteMovie(Movie movie);
    }
}