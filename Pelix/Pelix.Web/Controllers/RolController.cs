﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class RolController : Controller
    {
        // GET: RolController
        public ActionResult Index()
        {
            List<RolModel> rols = new List<RolModel>() 
            {
                new RolModel 
                {
                    cod_rol = 1,
                    txt_desc = "Admin",
                    sn_activo = 1
                },
                new RolModel 
                {
                    cod_rol = 2,
                    txt_desc = "Cliente",
                    sn_activo = 1
                }
            }; 
            return View(rols);
        }

        // GET: RolController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolController/Create
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

        // GET: RolController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolController/Edit/5
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

        // GET: RolController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RolController/Delete/5
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
