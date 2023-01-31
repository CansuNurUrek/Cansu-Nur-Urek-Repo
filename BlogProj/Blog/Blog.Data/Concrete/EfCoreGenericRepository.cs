using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog.Data.Abstract;
using System.Linq.Expressions;

namespace Blog.Data.Concrete
{
    
        public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
        {
            protected readonly DbContext _dbContext;

            public EfCoreGenericRepository(DbContext dbContext)
            {
                _dbContext = dbContext;
            }

      

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
           var homePosts = _dbContext
                .Set<TEntity>()
                .ToList();
            return homePosts;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext
                .Set<TEntity>()
                .FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
