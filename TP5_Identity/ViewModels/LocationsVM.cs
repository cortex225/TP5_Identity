using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models.ViewModels
{
    public class LocationsVM
    {
        public int Id { get; set; }

        [DisplayName("Date de location")]
        public DateTime DateLocation { get; set; }

        [DisplayName("Durée en jours")]
        public int DureeEnJours { get; set; }

        public int ClientId { get; set; }

        [DisplayName("Nom du Client")]
        public Client Clients { get; set; }

        public int VoitureId { get; set; }

        public Voiture Voiture { get; set; }
    }
}
