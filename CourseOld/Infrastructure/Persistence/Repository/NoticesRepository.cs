using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    internal sealed class NoticesRepository : BaseRepository<Guid, Notice>
    {
        public NoticesRepository(NoticesDbContext context) : base(context)
        {

        }

  

        public override async Task<Notice> AddCategory(Notice entity)
        {
            Category newCat = new Category();
            newCat.Name = entity.Category;
            newCat.Color = entity.Color;
            newCat.Owner = entity.UserOwner;

            await db.Category.AddAsync(newCat);
            await db.SaveChangesAsync();
            return entity;
        }
        public override async Task<Category> GetCategory(Guid id, CancellationToken cancellationToken = default)
        {
            return await db.Category.FindAsync(id);
        }
        public override async Task DeleteCategory(Guid id)
        {
            var cat = await db.Category.FindAsync(id);
            db.Category.Remove(cat);
            await db.SaveChangesAsync();   
        }
        public override async Task<IEnumerable<Category>> GetAllCategories(CancellationToken cancellationToken = default)
        {
            return await db.Category.ToListAsync();
        }
        public override async Task<Notice> Create(Notice entity)
        {
            await db.Notice.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }
           public override async Task<IEnumerable<Notice>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.Notice.ToListAsync();
        }
        public override async Task<Notice> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await db.Notice.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public override async Task Remove(Guid id)
        {
            var entity = await GetAsync(id);
            db.Entry(entity).State = EntityState.Deleted;
            await db.SaveChangesAsync();
        }

        public override async Task Update(Notice entity)
        {
            var updateNotice = await GetAsync(entity.Id);
            updateNotice.Name = entity.Name;
            updateNotice.Text = entity.Text;
            updateNotice.Category = entity.Category;
            updateNotice.Color = entity.Color;
            updateNotice.Deadline = entity.Deadline;
            updateNotice.IsFinished = entity.IsFinished;
            updateNotice.IsPublic = entity.IsPublic;
            updateNotice.UserOwner = entity.UserOwner;
            db.Entry(updateNotice).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public override Task UpdateAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

     
    }
}
