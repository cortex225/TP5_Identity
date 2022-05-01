using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TP5_Identity.Data;
using TP5_Identity.Models;
using TP5_Identity.Models.ViewModels;

namespace TP5_Identity.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;





        public LocationsController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager

            )
        {
            _context = context;
            _userManager = userManager;


        }

        // GET: Locations
        [Authorize(Roles = "admin,client,employe")]
        public IActionResult Index()
        {

            var applicationDbContext = _context.Locations
                .Include(l => l.Voitures)
                .Include(l => l.Voitures.Modele)
                .Include(l => l.Voitures.Modele.Marque)
                .Include(l => l.Client)
                .ToList();
            return View(applicationDbContext);
        }


        // GET: Locations/Create
        [Authorize(Roles = "admin,client,employe")]
        public IActionResult Create()
        {
            LocationsVM vm = new LocationsVM();
            vm.Client = _context.Clients.ToList();
            vm.Voitures = _context.Voitures.ToList();
            vm.Marques = _context.Marques.ToList();
            vm.Modeles = _context.Modeles.ToList();




            return View(vm);
        }

        [HttpPost]
        [Authorize(Roles = "admin,client,employe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LocationsVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Location nouvelleLocation = new Location();
                    nouvelleLocation.ClientId = vm.ClientId;
                    nouvelleLocation.Id = vm.Id;
                    nouvelleLocation.VoitureId = vm.VoitureId;
                    nouvelleLocation.DateLocation = vm.DateLocation;
                    nouvelleLocation.DureeEnJours = vm.DureeEnJours;




                    _context.Locations.Add(nouvelleLocation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                vm.Client = _context.Clients.ToList();
                vm.Voitures = _context.Voitures.ToList();


                return View(vm);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }


        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Locations
                .Include(l => l.Voitures)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
