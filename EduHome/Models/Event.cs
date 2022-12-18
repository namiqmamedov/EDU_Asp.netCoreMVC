using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event : BaseEntity
    {

        [StringLength(45)]
        public string Date { get; set; }
        [StringLength(255)]
        public string EventDate { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public IEnumerable<EventDescription> EventDescriptions { get; set; }
        public IEnumerable<EventTag> EventTags { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        [StringLength(255)]
        public string FormName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Subject { get; set; }
        [StringLength(800)]
        public string Message { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        [NotMapped]
        [MaxLength(5)]
        public IEnumerable<int> TagIds { get; set; }

    }
}
