using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class ContactForm : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]

        public string FormName { get; set; }
        [StringLength(255)]

        public string FormEmail { get; set; }
        [StringLength(255)]

        public string FormSubject { get; set; }
        [StringLength(255)]

        public string FormMessage { get; set; }

    }
}
