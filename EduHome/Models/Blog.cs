using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Blog : BaseEntity
    {

        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(45)]
        public DateTime Date { get; set; }
        [StringLength(255)]
        public int Comment { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
      
        [StringLength(255)]
        public string Image { get; set; }
  

        public IEnumerable<BlogTag> BlogTags { get; set; }
        public IEnumerable<BlogDescription> BlogDescriptions { get; set; }

        [StringLength(255)]
        public string FormName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [StringLength(800)]
        public string Message { get; set; }
    }
}
