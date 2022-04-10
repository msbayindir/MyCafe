using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyCafeBusinessLayer.EFCore.Abstract;


namespace MyCafeBusinessLayer.EFCore.Concrete
{
	public class BaseRepostory<T>:IEntityRepostory<T>
        where T : class, new()
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
            using (var _context = new MyCafeDbContext())
            {
                return _context.Set<T>().ToList();
            }
        }

        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            using (var _context = new MyCafeDbContext())
            {
                return _context.Set<T>().SingleOrDefault(filter);
            }
        }
        //public T GetSingle(T entity)
        //{
        //    using (var _context = new MyCafeDbContext())
        //    {
        //        return _context.Set<T>().T
        //    }
        //}
    }
}

