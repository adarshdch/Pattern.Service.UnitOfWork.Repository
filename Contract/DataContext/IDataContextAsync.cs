
using System.Threading;
using System.Threading.Tasks;

namespace Contract.DataContext
{
	public interface IDataContextAsync : IDataContext
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
		Task<int> SaveChangesAsync();
	}
}
