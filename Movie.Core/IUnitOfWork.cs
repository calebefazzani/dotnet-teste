using System;
using System.Threading.Tasks;
using Movie.Core.Repositories;

namespace Movie.Core 
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        Task<int> CommitAsync();
    }
}