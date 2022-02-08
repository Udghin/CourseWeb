using AutoMapper;
using Domain.Entity;
using Services.Abstractions.Dto.Notice;

//using Services.Abstractions.Dto.Order;
//using Services.Abstractions.Dto.Purchase;
//using Services.Abstractions.Dto.StoreBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AutoMapper.Profiles
{
    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            CreateMap<Notice, NoticeDto>().ReverseMap();
          //  CreateMap<NoticeDto, Notice>().ReverseMap();
            CreateMap<Notice, CreateNoticeDto>().ReverseMap();
            CreateMap<Notice, UpdateNoticeDto>().ReverseMap();
            //CreateMap<UpdateNoticeDto, Notice>().ReverseMap();
            //CreateMap<NoticeDto, CreateNoticeDto>().ReverseMap();
            //CreateMap<NoticeDto, UpdateNoticeDto>().ReverseMap();
        }
    }
}
