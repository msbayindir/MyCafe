using System;
namespace MyCafeBusinessLayer.EFCore.Abstract
{
	public interface IEntityRepostory<T>
	{

		List<T> GetAll();
		T GetSingle(T entity);
		void Add(T entity);
	}
}

