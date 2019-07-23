using System.Threading.Tasks;

namespace MoviesAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}