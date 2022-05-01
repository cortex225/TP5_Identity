using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP5_Identity.Models.ViewModels
{
    public class EmployesVM
    {
       

        [Required(ErrorMessage = "Le nom est requis.")]
        public string Nom { get; set; }

        [EmailAddress(ErrorMessage = "Vous devez entrer un courriel valide.")]
        [Required(ErrorMessage = "Le courriel est requis.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Le numéro d'employé est requis.")]
        [DisplayName("Numéro d'employé")]
        public int NoEmploye { get; set; }

        [DisplayName("Date d'embauche")]
        [Required(ErrorMessage = "La date d'embauche est requise.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateEmbauche { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot De Passe")]
        public string Password { get; set; }

    }
}
