using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyCafeDAL.Interfaces;

namespace MyCafeDAL.Repositories
{
	public class Repository<T>:IRepository<T>
        where T:class,new()
	{
        private readonly MyCafeDbContext _myCafeDbContext;
		

        public Repository(MyCafeDbContext myCafeDbContext)
        {
            _myCafeDbContext = myCafeDbContext;
        }

        public async Task Add(T entity)
        {
           await _myCafeDbContext.Set<T>().AddAsync(entity);
        }

        public async Task AddWithParams(params T[] entities)
        {

            await _myCafeDbContext.Set<T>().AddRangeAsync(entities);
            
        }

        public async Task<List<T>> GetAll()
        {
            return await _myCafeDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return asNoTracking ? await _myCafeDbContext.Set<T>().SingleOrDefaultAsync(filter) :
                await _myCafeDbContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetSingle(object id)
        {
            return await _myCafeDbContext.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            _myCafeDbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _myCafeDbContext.Set<T>().Update(entity);
        }
    }
}

