using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Interfaces
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingsAsync();
    }
}
