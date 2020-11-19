using System.Threading.Tasks;
using Movie.Core;
using Movie.Core.Repositories;
using Movie.Data.Repositories;

namespace Movie.Data 
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieDbContext _context;
        private MovieRepository _movieRepository;

        public UnitOfWork(MovieDbContext context)
        {
            this._context = context;
        }

        public IMovieRepository Movies => _movieRepository = _movieRepository ?? new MovieRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}