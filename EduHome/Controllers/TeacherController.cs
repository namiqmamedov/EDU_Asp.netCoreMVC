using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.Include(ti => ti.TeacherImages).ToList();
            
            return View(teachers);
        }

        public IActionResult TeacherDetail(int? id)
        {
            Teacher teacher = _context.Teachers.Include(pi => pi.TeacherImages).FirstOrDefault(t => t.Id == id);


            return View(teacher);
        }
    }
}

