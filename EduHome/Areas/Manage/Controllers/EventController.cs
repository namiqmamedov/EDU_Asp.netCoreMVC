using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public EventController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Event> events = await _context.Events
            .Include(c => c.Category)
            .Include(et => et.EventTags).ThenInclude(et => et.Tag)
            .Include(ts => ts.EventSpeakers).ThenInclude(t => t.Teacher)
            .Where(e => e.IsDeleted == false).ToListAsync();

            return View();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Events = await _context.Events
            .Where(t => t.IsDeleted == false)
            .ToListAsync();
           

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Event events)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();
            ViewBag.EventSpeakers = await _context.EventSpeakers.Where(s => s.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(events);
            }

            if (!await _context.Events.AnyAsync(e=>e.IsDeleted == false && e.Id == events.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Selected category is not correct.");
                return View(events);
            }

            List<EventTag> eventTags = new List<EventTag>();

            foreach (int tagId in events.TagIds)
            {
                if (events.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "You can't use the same tag more than once !");
                    return View(events);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Selected category is not correct.");
                    return View(events);
                }

                EventTag eventTag = new EventTag
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                eventTags.Add(eventTag);
            }


            events.Title = events.Title;
            events.IsDeleted = false;
            events.CreatedAt = DateTime.Now;
            events.CreatedBy = "System";

            await _context.Events.AddAsync(events);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }
}
