using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class DetailTitle : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
    }
}
