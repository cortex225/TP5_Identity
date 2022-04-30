using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP5_Identity.Models
{
    public class Location
    {
        public int Id { get; set; }

        [DisplayName("Dâte de location")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateLocation { get; set; }

        [DisplayName("Durée en jours")]
        public int DureeEnJours { get; set; }

        public string ClientId { get; set; }

        [DisplayName("Nom du Client")]
        public Client Client { get; set; }


        public int VoitureId { get; set; }
        [DisplayName("Voitures disponibles")]
        public Voiture Voitures { get; set; }


    }
}
