using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class AboutNotice : BaseEntity
    {
        public DateTime Date { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}
