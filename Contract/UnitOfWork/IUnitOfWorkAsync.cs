
using System.Threading;
using System.Threading.Tasks;
using Contract.Infrastructure;
using Contract.Repository;

namespace Contract.UnitOfWork
{
	public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}
