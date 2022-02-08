using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Dto.Notice
{
    public class NoticeAndCatsDto
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<NoticeDto> Notices { get; set; } = new List<NoticeDto>();
        public string UserId  { get; set; }
        public string Errors  { get; set; }
        public string Sort { get; set; }
        public string Search { get; set; }
        public string SearchType { get; set; }
    }
}
