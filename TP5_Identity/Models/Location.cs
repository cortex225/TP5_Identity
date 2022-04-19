using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.Models
{
    public class Location
    {

        public int Id { get; set; }

        public DateTime DateLocation { get; set; }

        public int DureeEnJours { get; set; }

        public int ClientId { get; set; }

        public Client Clients { get; set; }

        public int VoitureId { get; set; }

        public Voiture Voiture { get; set; }
    }
}
