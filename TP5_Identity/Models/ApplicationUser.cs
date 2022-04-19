using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String Nom { get; set; }

        public String Aderesse { get; set; }
    }
}
