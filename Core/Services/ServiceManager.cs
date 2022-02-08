using Domain.Repository;
using Services.Abstractions.Service;
using Services.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<INoticeService> _noticesService;
        public INoticeService NoticesService => _noticesService.Value;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _noticesService = new Lazy<INoticeService>(() => new NoticesService(unitOfWork));

        }
    }
}
