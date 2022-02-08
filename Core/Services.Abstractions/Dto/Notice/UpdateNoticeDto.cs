using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.Dto.Notice
{
    public class UpdateNoticeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public bool IsPublic { get; set; }
        public string UserOwner { get; set; }
    }
}
