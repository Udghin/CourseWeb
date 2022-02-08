using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IRepository<TKey, TValue>
        where TKey : struct
        where TValue : BaseEntity<TKey>
    {
    
        Task<IEnumerable<TValue>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TValue> GetAsync(TKey id, CancellationToken cancellationToken = default);
        Task<TValue> Create(TValue entity);
        Task Remove(TKey id);
        Task Update(TValue entity);

        Task AddCategory(TValue entity);
        Task DeleteCategory(TKey id);
        Task GetCategory(TKey id);
        Task<IEnumerable<Category>> GetAllCategories(CancellationToken cancellationToken = default);


        Task UpdateAsync(TKey entityId);
        
    }
}
