using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Dto.Notice
{
    public class CreateApiNoticeDto
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
        public string Color { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }
        public bool IsPublic { get; set; }
    }
}
