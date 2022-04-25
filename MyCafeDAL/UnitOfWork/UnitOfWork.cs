using System;
using MyCafeDAL.Interfaces;
using MyCafeDAL.Repositories;

namespace MyCafeDAL.UnitOfWork
{
	public class UnitOfWork:IUow
	{
        private readonly MyCafeDbContext _dbContext;

        public UnitOfWork(MyCafeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_dbContext);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}

