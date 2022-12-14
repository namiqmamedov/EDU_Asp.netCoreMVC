using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class BlogDescription : BaseEntity
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int DescriptionId { get; set; }
        public Description Description { get; set; }
    }
}
