using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class AboutVideo : BaseEntity
    {

        [StringLength(255)]
        public string VideoPopup { get; set; }
    }
}
