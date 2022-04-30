using System;

namespace TP5_Identity.Models
{
    public class Employe : ApplicationUser
    {


        public int NoEmploye { get; set; }

        public DateTime DateEmbauche { get; set; }


    }
}
