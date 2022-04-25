using System;
using MyCafeDAL.Interfaces;

namespace MyCafeDAL.UnitOfWork
{
	public interface IUow
	{
		IRepository<T> GetRepository<T>()where T: class,new();
		Task SaveChanges();
	}
}

