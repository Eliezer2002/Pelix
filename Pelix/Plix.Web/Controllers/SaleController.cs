using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class SaleController : Controller
    {
        // GET: SaleController
        public ActionResult Index()
        {
            List<SaleModel> sales = new List<SaleModel>() 
            {
                new SaleModel() 
                {
                    Id = 1,
                    cod_pelicula = 3,
                    cod_usuario = 3,
                    precio = 2000,
                    fecha = System.DateTime.Now
                },
                new SaleModel() 
                {
                    Id = 2,
                    cod_pelicula = 2,
                    cod_usuario = 1,
                    precio = 5000,
                    fecha = System.DateTime.Now
                }
            };
            return View(sales);
        }

        // GET: SaleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleController/Create
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

        // GET: SaleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaleController/Edit/5
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

        // GET: SaleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaleController/Delete/5
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
