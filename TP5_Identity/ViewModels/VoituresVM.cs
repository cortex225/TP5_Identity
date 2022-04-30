using System.Collections.Generic;
using System.ComponentModel;

namespace TP5_Identity.Models.ViewModels
{
    public class VoituresVM
    {


        public int Id { get; set; }

        [DisplayName("Année")]
        public int Annee { get; set; }

        public string Couleur { get; set; }

        [DisplayName("Prix Journalier")]
        public double PrixJournalier { get; set; }

        public int ModeleId { get; set; }
        [DisplayName("Modèle")]
        public Modele Modele { get; set; }


        public List<Location> Locations { get; set; }


    }
}
