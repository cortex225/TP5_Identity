using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class Modele
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int MarqueId { get; set; }

        public Marque Marque { get; set; }
    }
}
