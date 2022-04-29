using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP5_Identity.ViewModels.Comptes
{
    public class RecupererMdpVM
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&*])[0-9a-zA-Z!@#$%^&*0-9]{6,}$",
        ErrorMessage = "Le mot de passe doit avoir minimalement 6 caractères et doit contenir au moins un caractère spécial, une minuscule et une majuscule")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe ")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
}
