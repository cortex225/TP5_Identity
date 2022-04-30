using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP5_Identity.Controllers
{
    public class EmployesController : Controller
    {
        // GET: EmployesController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EmployesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployesController1/Edit/5
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

        // GET: EmployesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployesController1/Delete/5
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
