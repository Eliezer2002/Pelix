using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class GeneroPeliculaController : Controller
    {
        // GET: GeneroPeliculaController
        public ActionResult Index()
        {
            List<GeneroPeliculaModel> generoPeliculas = new List<GeneroPeliculaModel>()
            {
                new GeneroPeliculaModel
                {
                    cod_genero = 1,
                    cod_pelicula = 1
                },
                new GeneroPeliculaModel
                {
                    cod_genero = 2,
                    cod_pelicula = 2
                },
            };
            return View(generoPeliculas);
        }

        // GET: GeneroPeliculaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneroPeliculaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneroPeliculaController/Create
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

        // GET: GeneroPeliculaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneroPeliculaController/Edit/5
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

        // GET: GeneroPeliculaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneroPeliculaController/Delete/5
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
