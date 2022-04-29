using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP5_Identity.Data;
using TP5_Identity.Models;
using TP5_Identity.ViewModels;
using TP5_Identity.ViewModels.Comptes;

namespace TP5_Identity.Controllers
{
    [Authorize]
    public class ComptesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ConnectionVM> _logger;
        private readonly ApplicationDbContext _context;

        public ComptesController(SignInManager<ApplicationUser> signInManager,
            ILogger<ConnectionVM> logger,
            UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }
       

        [AllowAnonymous]
        [Route("Compte/Connecter")]
        public IActionResult Connecter()
        {
            
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [Route("Compte/Connecter")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Connecter(ConnectionVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
            //trouver l'utilisateur qui tente de se connecter
            var user = await _userManager.FindByEmailAsync(model.Email);
           
            if (result.Succeeded)
            {
                _logger.LogInformation("L'utilisateur est connecté.");
                return RedirectToAction("Index", "Home");
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("L'utilisateur est barré.");
                return RedirectToPage("./Lockout");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Tentative de connection non valide.");
                return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin,client,employe")]
        public async Task<ActionResult> RecuperationMDP(string id)
        {

            ApplicationUser user = new ApplicationUser();

            if (String.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            RecupererMdpVM vm = new RecupererMdpVM();

            vm.Id = _userManager.GetUserId(User);
            if (id != vm.Id)
            {
                return Content("Vous ne pouvez pas modifier le mot de passe des autres!");
            }


            return View(vm);
        }

        [HttpPost]
        [Authorize(Roles = "admin,client,employe")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RecuperationMDP(RecupererMdpVM vm)
        {

            if (!ModelState.IsValid)
            {
                return View("RecuperationMDP", vm);
            }
            try
            {
                ApplicationUser user = await _userManager.FindByIdAsync(vm.Id);
                if (user == null)
                {
                    return NotFound();
                }
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, vm.Password);
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return View("RecuperationMDP", vm);
                }

            }
            catch (Exception)
            {
                return View("Error");
            }

            return RedirectToAction("Index", "Home");

        }

      


    }
}
