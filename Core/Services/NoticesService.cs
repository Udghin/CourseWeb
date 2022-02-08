
using Domain.Entity;
using Domain.Repository;
using Services.Abstractions.Dto.Notice;
using Services.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public class NoticesService : INoticeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AutoMapper.ObjectMapper objectManager = AutoMapper.ObjectMapper.Instance;
        public NoticesService(IUnitOfWork uow)
        {
                       unitOfWork = uow;
        }
        public async Task<NoticeDto> CreateAsync(CreateNoticeDto model, CancellationToken cancellationToken = default)
        {
            var notice = await unitOfWork.NoticesRepository.Create(objectManager.Mapper.Map<Notice>(model));
            return objectManager.Mapper.Map<NoticeDto>(notice);
         
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await unitOfWork.NoticesRepository.GetAsync(id);
            await unitOfWork.NoticesRepository.Remove(result.Id);
        }

        public async Task<IEnumerable<NoticeDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var result = await unitOfWork.NoticesRepository.GetAllAsync();
            return objectManager.Mapper.Map<IEnumerable<NoticeDto>>(result).ToList();
        }
        public async Task<IEnumerable<NoticeDto>> GetAllPublicAsync(CancellationToken cancellationToken = default)
        {
            var result = await unitOfWork.NoticesRepository.GetAllAsync();
            List<Notice> tmp = new List<Notice>();
            foreach(var not in result)
            {
                if (not.IsPublic == true && not.Deadline>DateTime.Now) tmp.Add(not);
            }
            var res = result.Where(e => e.IsPublic == true);
            return objectManager.Mapper.Map<IEnumerable<NoticeDto>>(tmp).ToList();
        }

        public async Task<NoticeAndCatsDto> GetAllByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            var cats = await GetAllCategories();
            var notices = await GetAllAsync();
            NoticeAndCatsDto res = new NoticeAndCatsDto();
            foreach (var not in notices)
            {
                if (not.UserOwner == name) res.Notices.Add(not);
            }
            foreach (var cat in cats)
            {
                if (cat.Owner == name) res.Categories.Add(cat);
            }
            res.Notices=res.Notices.OrderBy(n => n.Category).ToList();
            return res;
        }

        public async Task<NoticeDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return objectManager.Mapper.Map<NoticeDto>(await unitOfWork.NoticesRepository.GetAsync(id));
        }

        public async Task UpdateAsync(UpdateNoticeDto model, CancellationToken cancellationToken = default)
        {
            var result = objectManager.Mapper.Map<Notice>(model);
            await unitOfWork.NoticesRepository.Update(result);
        }

        public async Task Update(NoticeDto model, CancellationToken cancellationToken = default)
        {
            var result = objectManager.Mapper.Map<Notice>(model);
            await unitOfWork.NoticesRepository.Update(result);
        }

        public async Task<IEnumerable<NoticeDto>> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await unitOfWork.NoticesRepository.GetAsync(id);
            return objectManager.Mapper.Map<IEnumerable<NoticeDto>>(result).ToList();
        }

        public Task AddCategory(Notice model, CancellationToken cancellationToken = default)
        {
            return unitOfWork.NoticesRepository.AddCategory(model);
        }

        public Task DeleteCategory(Guid id, CancellationToken cancellationToken = default)
        {
            return unitOfWork.NoticesRepository.DeleteCategory(id);
        }

        public Task<Category> GetCategory(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategories(CancellationToken cancellationToken = default)
        {
            return await unitOfWork.NoticesRepository.GetAllCategories();
        }

    }
}
