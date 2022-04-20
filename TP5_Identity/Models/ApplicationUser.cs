using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nom { get; set; }

        public string Aderesse { get; set; }
    }
}
