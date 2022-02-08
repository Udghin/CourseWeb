using Domain.Entity;
using Services.Abstractions.Dto.Notice;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Abstractions.Services
{
    public interface INoticeService
    {
        Task<IEnumerable<NoticeDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<NoticeDto>> GetAllPublicAsync(CancellationToken cancellationToken = default);
        Task<NoticeAndCatsDto> GetAllByNameAsync(string name,CancellationToken cancellationToken = default);

        Task<IEnumerable<NoticeDto>> GetAsync(Guid id, CancellationToken cancellationToken = default);
        Task<NoticeDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<NoticeDto> CreateAsync(CreateNoticeDto model, CancellationToken cancellationToken = default);
        Task UpdateAsync(UpdateNoticeDto model, CancellationToken cancellationToken = default);
        Task Update(NoticeDto model, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);

        Task AddCategory(Notice model, CancellationToken cancellationToken = default);
        Task DeleteCategory(Guid id, CancellationToken cancellationToken = default);
        Task<Category> GetCategory(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Category>> GetAllCategories(CancellationToken cancellationToken = default);
    }
}
