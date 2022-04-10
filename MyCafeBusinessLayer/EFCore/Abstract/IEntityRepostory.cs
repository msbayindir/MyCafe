using System;
using System.Linq.Expressions;

namespace MyCafeBusinessLayer.EFCore.Abstract
{
	public interface IEntityRepostory<T>
		where T : class, new()
	{

		List<T> GetAll();
		T GetSingle(Expression<Func<T, bool>> filter);
		void Add(T entity);
	}
}

