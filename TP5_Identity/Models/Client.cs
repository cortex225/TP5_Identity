using System.ComponentModel.DataAnnotations.Schema;

namespace TP5_Identity.Models
{
    public class Client : ApplicationUser
    {
       

        public string Adresse { get; set; }

        public int AbonnementId { get; set; }

        public Abonnement Abonnement { get; set; }

      

    }
}
