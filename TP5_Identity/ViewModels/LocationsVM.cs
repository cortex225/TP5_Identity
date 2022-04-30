using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP5_Identity.Models.ViewModels
{
    public class LocationsVM
    {
        public int Id { get; set; }

        [DisplayName("Date de location")]
        [Required(ErrorMessage = "La date de location est requise.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateLocation { get; set; }

        [DisplayName("Durée en jours")]
        [Required(ErrorMessage = "La durée en jour est requise.")]
        [MinLength(1, ErrorMessage = "La durée en jour doit être minimum de 1 jour.")]
        public int DureeEnJours { get; set; }

        [Required(ErrorMessage = "Vous devez choisir un client.")]
        [DisplayName("Nom du Client")]
        public string ClientId { get; set; }
        public List<Client> Client { get; set; }

        [DisplayName("Voitures disponibles")]
        [Required(ErrorMessage = "Vous devez choisir une voiture.")]
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
