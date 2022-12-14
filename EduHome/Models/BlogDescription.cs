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

        public string SimpleDescription { get; set; }
        public string QuoteDescription { get; set; }
    }
}
