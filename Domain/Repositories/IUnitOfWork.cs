using System.Threading.Tasks;

namespace AnimalsAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}