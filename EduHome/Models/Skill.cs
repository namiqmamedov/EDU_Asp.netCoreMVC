using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Skill : BaseEntity
    {

        [StringLength(55)]
        public string SkillName { get; set; }
       
    }
}
