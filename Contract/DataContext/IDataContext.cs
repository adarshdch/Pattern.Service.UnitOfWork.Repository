using System;
using Contract.Infrastructure;

namespace Contract.DataContext
{
	public interface IDataContext : IDisposable
	{
		int SaveChanges();
		void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
		void SyncObjectsStatePostCommit();
	}
}
