using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Description : BaseEntity
    {
        public string SimpleDescription { get; set; }
        public string QuoraDescription { get; set; }
    }
}
