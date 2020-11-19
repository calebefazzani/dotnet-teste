using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.Core.Models;
using Movie.Core.Repositories;
using Movie.Data.Configurations;

namespace Movie.Data.Repositories 
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieDbContext context) : base(context)
        {
        }

    }
}