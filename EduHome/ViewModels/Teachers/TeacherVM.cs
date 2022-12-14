using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Teachers
{
    public class TeacherVM
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<TeacherHobby> TeacherHobbies { get; set; }
        public IEnumerable<TeacherSkill> TeacherSkills { get; set; }
    }
}
