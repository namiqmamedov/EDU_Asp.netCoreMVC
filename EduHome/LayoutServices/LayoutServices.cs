using EduHome.DAL;
using EduHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.LayoutServices
{
    public class LayoutServices : ILayoutServices
    {
        private readonly AppDbContext _context;
        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

    }
}
