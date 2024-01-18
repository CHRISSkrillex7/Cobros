using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cobros.Controllers
{
    public class AgregarAlumnoController : Controller
    {
        // GET: AgregarAlumnoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AgregarAlumnoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AgregarAlumnoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgregarAlumnoController/Create
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

        // GET: AgregarAlumnoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgregarAlumnoController/Edit/5
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

        // GET: AgregarAlumnoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgregarAlumnoController/Delete/5
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
