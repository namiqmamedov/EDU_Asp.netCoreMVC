using EduHome.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        
        }

        public async Task<Dictionary<string,string>> GetSettingsAsync()
        {
            return await _context.Settings.
               ToDictionaryAsync(s => s.Key, s => s.Value);
        }
    }
}
