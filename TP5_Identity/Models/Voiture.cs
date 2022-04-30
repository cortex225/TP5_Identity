using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP5_Identity.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        [DisplayName("Année")]
        public int Annee { get; set; }

        public string Couleur { get; set; }

        public double PrixJournalier { get; set; }

        public int ModeleId { get; set; }

        [DisplayName("Modèle")]
        public Modele Modele { get; set; }

        public List<Location> Locations { get; set; }


        [NotMapped]
        [DisplayName("Voitures disponibles")]
        public string VoituresDispo
        {
            get
            {

                return $" {Modele.Marque.Nom} {Modele.Nom} {Annee} {Couleur}";
            }
        }

    }
}
