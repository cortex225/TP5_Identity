using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using TP5_Identity.Data;
using TP5_Identity.Models;
using TP5_Identity.Models.ViewModels;

namespace TP5_Identity.Controllers
{
    public class ClientsController : Controller
    {


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ClientsVM> _logger;
        private readonly ApplicationDbContext _context;

        public ClientsController(SignInManager<ApplicationUser> signInManager,
            ILogger<ClientsVM> logger,
            UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }




        // GET: ClientsController
        [HttpGet, Authorize(Roles = "admin,client,employe")]
        public ActionResult Index()
        {
            var applicationDbContext = _context.Clients
                  .Include(l => l.Abonnement)
                  .ToList();
            return View(applicationDbContext);
        }



        // GET: ClientsController/Creer
        [HttpGet, AllowAnonymous]
        [Route("Clients/Creer")]
        public ActionResult Create()
        {
            ClientsVM vm = new ClientsVM();
            vm.Abonnements = _context.Abonnements.ToList();
            return View(vm);
        }

        // POST: ClientsController/Creer
        [HttpPost, AllowAnonymous]
        [Route("Clients/Creer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientsVM vm)
        {
            if (ModelState.IsValid)
            {
                var password = new PasswordHasher<ApplicationUser>();
                var userCheck = await _userManager.FindByEmailAsync(vm.Courriel);
                vm.Abonnements = _context.Abonnements.ToList();
                if (userCheck == null)
                {
                    var user = new Client
                    {

                        Nom = vm.Nom,
                        Adresse = vm.Adresse,
                        UserName = vm.Courriel,
                        NormalizedUserName = vm.Courriel.ToUpper(),
                        NormalizedEmail = vm.Courriel.ToUpper(),
                        Email = vm.Courriel,
                        PhoneNumber = vm.Telephone,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        PasswordHash = password.HashPassword(userCheck, vm.Password),
                        AbonnementId = vm.AbonnementId

                    };
                    var result = await _userManager.CreateAsync(user, vm.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "client");
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        user.AbonnementId = vm.AbonnementId;
                        user.Adresse = vm.Adresse;

                        user.Nom = vm.Nom;
                        user.UserName = vm.Courriel;
                        user.NormalizedUserName = vm.Courriel.ToUpper();
                        user.NormalizedEmail = vm.Courriel.ToUpper();
                        user.Email = vm.Courriel;
                        user.PhoneNumber = vm.Telephone;
                        user.EmailConfirmed = true;
                        user.PhoneNumberConfirmed = true;
                        user.PasswordHash = password.HashPassword(userCheck, vm.Password);

                        return RedirectToAction("Index", "Clients");
                    }


                    else
                    {
                        if (result.Errors.Count() > 0)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("message", error.Description);
                            }
                        }
                        return View(vm);
                    }
                }
                else
                {
                    ModelState.AddModelError("message", "Cet utilisateur existe déjà.");
                    return View(vm);
                }
            }
            return View(vm);

        }


        // GET: Clients/Delete/5
        [Authorize(Roles = "admin,employe,client")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Abonnement)
                
                .FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "administrateur,employe,client")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
