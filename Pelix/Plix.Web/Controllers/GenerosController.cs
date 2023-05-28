using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class GenerosController : Controller
    {
        // GET: GenerosController
        public ActionResult Index()
        {
            List<GenerosModel> generos = new List<GenerosModel>()
            {
                new GenerosModel
                {
                    cod_genero= 1,
                    txt_desc = "Acción"
                },
                new GenerosModel 
                {
                    cod_genero= 2,
                    txt_desc = "Comedia"
                }
            };
            return View(generos);
        }

        // GET: GenerosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenerosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenerosController/Create
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

        // GET: GenerosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenerosController/Edit/5
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

        // GET: GenerosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenerosController/Delete/5
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
