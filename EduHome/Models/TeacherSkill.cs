using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherSkill : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        [StringLength(105)]
        public string Progress { get; set; }
        [StringLength(105)]
        public string Number { get; set; }
    }
}
