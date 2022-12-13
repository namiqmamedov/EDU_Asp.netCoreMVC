using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Contact
{
    public class ContactVM
    {
        public IEnumerable<ContactContent> ContactContents { get; set; }
        public IEnumerable<ContactForm> ContactForms { get; set; }

    }
}
