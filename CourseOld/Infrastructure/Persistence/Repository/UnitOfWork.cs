using Domain.Entity;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        NoticesDbContext db;
        readonly Lazy<IRepository<Guid, Notice>> _noticeRepository;
       // readonly Lazy<IRepository<Guid, Category>> _categoryRepository;
        public IRepository<Guid, Notice> NoticesRepository => _noticeRepository.Value;
      //  public IRepository<Guid, Category> CategoriesRepository => _categoryRepository.Value;

        public UnitOfWork(NoticesDbContext context)
        {
            db = context;
            _noticeRepository = new Lazy<IRepository<Guid, Notice>>(() => new NoticesRepository(context));
      //      _categoryRepository = new Lazy<IRepository<Guid, Category>>(() => new CategoriesRepository(context));
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return db.SaveChangesAsync();
        }
    }
}
