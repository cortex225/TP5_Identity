using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Index()
        {
            return View();
        }



        // GET: ClientsController1/Create
        [HttpGet, AllowAnonymous]
        public ActionResult Creer()
        {
            ClientsVM vm = new ClientsVM();
            return View(vm);
        }

        // POST: ClientsController/Create
        [HttpPost, AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Creer(ClientsVM vm)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await _userManager.FindByEmailAsync(vm.Courriel);
                if (userCheck == null)
                {
                    var user = new ApplicationUser
                    {
                        Id=vm.Id,
                        UserName = vm.Courriel,
                        NormalizedUserName = vm.Courriel.ToUpper(),
                        Email = vm.Courriel,
                        PhoneNumber = vm.Telephone,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                       // PasswordHash=vm.Password.ToHashSet(),
                    };
                    var result = await _userManager.CreateAsync(user, vm.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
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
                    ModelState.AddModelError("message", "Email already exists.");
                    return View(vm);
                }
            }
            return View(vm);

        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
