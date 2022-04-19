using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class Abonnement
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public float PrixMensuel { get; set; }

        public int RabaisPourcentage { get; set; }
    }
}
