using System;
using AnonymousBlog.Core.Entities;
using AnonymousBlog.Data.Repositories.Abstractions;

namespace AnonymousBlog.Data.UnitOfWorks
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

		Task<int> SaveAsync();
		int Save();
	}
}

