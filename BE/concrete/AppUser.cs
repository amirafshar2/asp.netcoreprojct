using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name_SureName { get; set; }
        public string İmage { get; set; }
    }
}
