using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: PeliculaController1
        public ActionResult Index()
        {
            List<PeliculaModel> peliculas = new List<PeliculaModel>() 
            {
                new PeliculaModel 
                {
                    cod_pelicula = 1,
                    txt_desc = "Nemo",
                    cant_disponibles_alquiler= 1,
                    cant_disponibles_venta = 1,
                    precio_alquiler = 1000,
                    precio_venta = 5000
                },
                new PeliculaModel 
                {
                    cod_pelicula = 2,
                    txt_desc = "Rapido y furiosos 7",
                    cant_disponibles_alquiler= 2,
                    cant_disponibles_venta = 0,
                    precio_alquiler = 2000,
                    precio_venta = 10000
                },
            }; 
            return View(peliculas);
        }

        // GET: PeliculaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeliculaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeliculaController1/Create
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

        // GET: PeliculaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeliculaController1/Edit/5
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

        // GET: PeliculaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeliculaController1/Delete/5
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
