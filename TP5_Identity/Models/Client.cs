namespace TP5_Identity.Models
{
    public class Client : ApplicationUser
    {




        public int AbonnementId { get; set; }

        public Abonnement Abonnement { get; set; }



    }
}
