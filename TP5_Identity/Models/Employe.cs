using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class Employe : ApplicationUser
    {
       

        public int NoEmploye { get; set; }

        public DateTime DateEmbauche { get; set; }

  
    }
}
