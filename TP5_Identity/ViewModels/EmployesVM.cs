using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models.ViewModels
{
    public class EmployesVM
    {
        public string Id { get; set; }

        public string Nom { get; set; }

        public string Courriel { get; set; }

        public int NoEmploye { get; set; }

        public DateTime DateEmbauche { get; set; }

    }
}
