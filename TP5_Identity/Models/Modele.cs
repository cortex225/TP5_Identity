using System.ComponentModel;

namespace TP5_Identity.Models
{
    public class Modele
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int MarqueId { get; set; }
        [DisplayName("Marque")]
        public Marque Marque { get; set; }
    }
}
