using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class EventDescription : BaseEntity
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        [StringLength(855)]
        public string SimpleDescription { get; set; }

        
    }
}
