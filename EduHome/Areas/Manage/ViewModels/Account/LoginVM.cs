﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Manage.ViewModels.Account
{
    public class LoginVM
    {
        public string UserName { get; set; }
     
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RemindMe { get; set; }
    }
}
