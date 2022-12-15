using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels.Teachers;
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
        public async Task<IActionResult> Index(int? id)
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Teachers = await _context.Teachers.Where(t => t.IsDeleted == false).ToListAsync(),

            };
                return View(teacherVM);           

        }
        public IActionResult TeacherDetail(int? id)
        {
            Teacher teacher = _context.Teachers.Include(sk=>sk.TeacherSkills).ThenInclude(sk=>sk.Skill).FirstOrDefault(t => t.Id == id);

            return View(teacher);
        }
    };


};




