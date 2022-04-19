using System.Collections.Generic;

namespace TP5_Identity.Models
{
    public class Voiture
    {

        public Voiture()
        {
            Locations = new List<Location>();
        }

        public int Id { get; set; }

        public int Annee { get; set; }

        public string Couleur { get; set; }

        public double PrixJournalier { get; set; }

        public int ModeleId { get; set; }

        public Modele Modele { get; set; }

        public List<Location> Locations { get; set; }

    }
}
