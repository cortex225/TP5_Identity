﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP5_Identity.Models.ViewModels
{
    public class LocationsVM
    {
        public int Id { get; set; }

        [DisplayName("Date de location")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateLocation { get; set; }

        [DisplayName("Durée en jours")]
        public int DureeEnJours { get; set; }

        public string ClientId { get; set; }

        [DisplayName("Nom du Client")]
        public List<Client> Client { get; set; }

        [DisplayName("Voitures disponibles")]
        public int VoitureId { get; set; }

        public List<Voiture> Voitures { get; set; }

        public int ModeleId { get; set; }
        public List<Modele> Modeles { get; set; }
        public int MarqueId { get; set; }
        public List<Marque> Marques { get; set; }

        public int Annee { get; set; }

        public string Couleur { get; set; }


    }
}
