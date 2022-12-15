using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Events
{
    public class EventDetailVM
    {
        public Event Event { get; set; }
        public List<Event> Events { get; set; }
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
