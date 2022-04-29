using Microsoft.AspNetCore.Identity;

namespace TP5_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nom { get; set; }

        public string Adresse { get; set; }


    }
}
