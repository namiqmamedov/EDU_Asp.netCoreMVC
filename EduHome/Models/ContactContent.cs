using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class ContactContent : BaseEntity
    {
        [StringLength(2500)]
        public string Icon { get; set; }

        [StringLength(2500)]
        public string Title { get; set; }
        [StringLength(2500)]
        public string MainDescription { get; set; }
        [StringLength(2500)]
        public string SubDescription { get; set; }
      

    };
}
