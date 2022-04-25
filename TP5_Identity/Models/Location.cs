using System;

namespace TP5_Identity.Models
{
    public class Location
    {

        public int Id { get; set; }

        public DateTime DateLocation { get; set; }

        public int DureeEnJours { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int VoitureId { get; set; }

        public Voiture Voiture { get; set; }
    }
}
