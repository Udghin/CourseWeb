using Services.Abstractions.Dto.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeWithoutShit.Models.Admin
{
    public class HomeIndexNoticeViewModel
    {
        public List<NoticeDto> Books { get; set; }
    }
}
