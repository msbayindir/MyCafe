using System;
using Microsoft.EntityFrameworkCore;
using MyCafeBusinessLayer.EFCore.Abstract;


namespace MyCafeBusinessLayer.EFCore.Concrete
{
	public class BaseRepostory<T>:IEntityRepostory<T>
        
	{
		public BaseRepostory()
		{
		}

        public void Add(T entity)
        {
            using(var _context = new MyCafeDbContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }
        
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetSingle(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

