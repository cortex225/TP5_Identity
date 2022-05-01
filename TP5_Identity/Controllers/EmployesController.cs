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
    public class EmployesController : Controller
    {


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<EmployesVM> _logger;
        private readonly ApplicationDbContext _context;

        public EmployesController(SignInManager<ApplicationUser> signInManager,
            ILogger<EmployesVM> logger,
            UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }




        // GET: EmployesController
        [HttpGet, Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var applicationDbContext = _context.Employes.ToList();
                  
            return View(applicationDbContext);
        }



        // GET: EmployesController/Creer
        [HttpGet]
        [Route("{Controller}/{Action}")]
        [HttpGet, Authorize(Roles = "admin")]
        public ActionResult Enregistrer()
        {
            EmployesVM vm = new EmployesVM();
           
           
            return View(vm);
        }

        // POST: EmployesController/Creer
        [HttpPost]
        [Route("{Controller}/{Action}")]
        [HttpGet, Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployesVM vm)
        {
            if (ModelState.IsValid)
            {
                var password = new PasswordHasher<ApplicationUser>();
                var userCheck = await _userManager.FindByEmailAsync(vm.Courriel);
               
                if (userCheck == null)
                {
                    var user = new Employe
                    {

                        Nom = vm.Nom,
                        Adresse = vm.Courriel,
                        UserName = vm.Courriel,
                        NormalizedUserName = vm.Courriel.ToUpper(),
                        NormalizedEmail = vm.Courriel.ToUpper(),
                        Email = vm.Courriel,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        DateEmbauche=vm.DateEmbauche,
                        PasswordHash = password.HashPassword(userCheck, vm.Password),
                        

                    };
                    var result = await _userManager.CreateAsync(user, vm.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "employe");
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        
                        user.Adresse = vm.Courriel;
                        user.Nom = vm.Nom;
                        user.UserName = vm.Courriel;
                        user.NormalizedUserName = vm.Courriel.ToUpper();
                        user.NormalizedEmail = vm.Courriel.ToUpper();
                        user.Email = vm.Courriel;
                        user.DateEmbauche = vm.DateEmbauche;
                        user.EmailConfirmed = true;
                        user.PhoneNumberConfirmed = true;
                        user.PasswordHash = password.HashPassword(userCheck, vm.Password);

                        return RedirectToAction("Index", "Employes");
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


        // GET: Employes/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Employe = await _context.Employes
              

                .FirstOrDefaultAsync(m => m.Id == id);
            if (Employe == null)
            {
                return NotFound();
            }

            return View(Employe);
        }

        // POST: Employes/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var Employe = await _context.Employes.FindAsync(id);
            _context.Employes.Remove(Employe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
