using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Repository
{

    internal abstract class BaseRepository<TKey, TValue> : IRepository<TKey, TValue>
        where TKey : struct
        where TValue : BaseEntity<TKey>
    {
        protected NoticesDbContext db;

        DbSet<TValue> Table => db.Set<TValue>();
   
        public BaseRepository(NoticesDbContext context)
        {
            db = context;
        }

        public abstract Task<TValue> Create(TValue entity);

        public abstract Task<TValue> GetAsync(TKey id, CancellationToken cancellationToken = default);

        public abstract Task<IEnumerable<TValue>> GetAllAsync(CancellationToken cancellationToken = default);

        public abstract Task Remove(TKey id);

        public abstract Task Update(TValue entity);


        public abstract Task AddCategory(TValue entity);
        public abstract Task DeleteCategory(TKey id);
        public abstract Task<Category> GetCategory(TKey id, CancellationToken cancellationToken = default);
        public abstract Task<IEnumerable<Category>> GetAllCategories(CancellationToken cancellationToken = default);



        public abstract Task UpdateAsync(TKey entityId);

        public Task GetCategory(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}
