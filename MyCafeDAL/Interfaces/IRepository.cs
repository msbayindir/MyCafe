using System;
using System.Linq.Expressions;

namespace MyCafeDAL.Interfaces
{
	public interface IRepository<T>
		where T:class,new()
	{
		Task<List<T>> GetAll();
		Task<T> GetSingle(object id);
		Task Add(T entity);
		Task<T?> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false);
		Task AddWithList(List<T> entities);
		void Update(T entity);
		void Remove(T entity);

		IQueryable<T> GetQuery();

	}
}

