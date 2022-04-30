using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TP5_Identity.Data;
using TP5_Identity.Models.ViewModels;

namespace TP5_Identity.Controllers
{
    public class VoituresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoituresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Voitures
        [AllowAnonymous]
        public IActionResult Index()
        {
            var vm = _context.Voitures
                .Include(v => v.Modele)
                .OrderBy(v => v.Annee)
                .Select(voitures => new VoituresVM()
                {
                    Id = voitures.Id,
                    Annee = voitures.Annee,
                    Couleur = voitures.Couleur,
                    Locations = voitures.Locations,
                    Modele = voitures.Modele,
                    ModeleId = voitures.ModeleId,
                    PrixJournalier = voitures.PrixJournalier

                })

                .ToList();

            return View(vm);
        }


    }
}
