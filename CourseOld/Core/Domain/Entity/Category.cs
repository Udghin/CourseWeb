using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
    }
}
