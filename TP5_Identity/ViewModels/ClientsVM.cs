using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models.ViewModels
{
    public class ClientsVM
    {

        public string Adresse { get; set; }

        public int AbonnementId { get; set; }

        public Abonnement Abonnement { get; set; }


    }
}
