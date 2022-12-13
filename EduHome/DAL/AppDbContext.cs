using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeLeft> NoticeLefts { get; set; }
        public DbSet<NoticeRight> NoticeRights { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<AboutContent> AboutContents { get; set; }
        public DbSet<ContactContent> ContactContents { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherHobby> TeacherHobbies { get; set; }
        public DbSet<TeacherImage> TeacherImages { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
       

    }
}
