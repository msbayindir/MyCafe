using System;
namespace MyCafeDAL.Interfaces
{
	public interface IRepository<T>
		where T:class,new()
	{
		Task<List<T>> GetAll();


	}
}

