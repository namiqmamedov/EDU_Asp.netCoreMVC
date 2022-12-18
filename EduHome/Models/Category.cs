using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
