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
        public DbSet<AboutNotice> AboutNotices { get; set; }
        public DbSet<AboutVideo> AboutVideo { get; set; }
        public DbSet<ContactContent> ContactContents { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<BlogDescription> BlogDescriptions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<EventDescription> EventDescriptions { get; set; }
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<CourseDetailTitle> CourseDetailTitles { get; set; }
        public DbSet<SubscribeArea> SubscribeAreas { get; set; }
       

    }
}
