using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Events
{
    public class EventVM
    {
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<EventCategory> EventCategories { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public IEnumerable<EventDescription> EventDescriptions { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
