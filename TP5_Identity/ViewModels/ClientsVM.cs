using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP5_Identity.Models.ViewModels
{
    public class ClientsVM
    {
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le courriel est requis.")]
        [EmailAddress(ErrorMessage = "Vous devez entrer un courriel valide.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot De Passe")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Adresse { get; set; }

        [Display(Name = "Abonnement")]
        [Required(ErrorMessage = "Le type d'abonement est requis.")]
        public int AbonnementId { get; set; }

        public List<Abonnement> Abonnements { get; set; }


    }
}
