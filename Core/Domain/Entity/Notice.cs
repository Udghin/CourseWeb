using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Notice: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public bool IsPublic { get; set; }
        public bool IsFinished { get; set; }
        public string UserOwner { get; set; }
    }
}
