using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class RentController : Controller
    {
        // GET: RentController
        public ActionResult Index()
        {
            List<RentModel> rents = new List<RentModel>() 
            {
                new RentModel 
                {
                    Id = 1,
                    cod_pelicula = 1,
                    cod_usuario = 1,
                    precio = 1000,
                    fecha = System.DateTime.Now,
                    devuelta = 1,
                    fecha_devolucion = System.DateTime.Now, 
                    cod_usuario_devolucion = 1

                },
                new RentModel 
                {
                    Id = 2,
                    cod_pelicula = 2,
                    cod_usuario = 2,
                    precio = 2000,
                    fecha = System.DateTime.Now,
                    devuelta = 1,
                    fecha_devolucion = System.DateTime.Now,
                    cod_usuario_devolucion = 2
                }
            };
            return View(rents);
        }

        // GET: RentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentController/Create
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

        // GET: RentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentController/Edit/5
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

        // GET: RentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentController/Delete/5
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
