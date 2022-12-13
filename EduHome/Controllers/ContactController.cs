using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ContactVM contactVM = new ContactVM
            {
                ContactContents = await _context.ContactContents.Where(t => t.IsDeleted == false).ToListAsync(),
                ContactForms = await _context.ContactForms.Where(t => t.IsDeleted == false).ToListAsync(),

            };

            return View(contactVM);
        }

        
    }
}
