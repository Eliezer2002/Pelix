using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelix.Web.Models;
using System.Collections.Generic;

namespace Pelix.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>() 
            {
                new UserModel() 
                {
                    cod_usuario = 1,
                    txt_user = "Admin",
                    txt_password = "password",
                    txt_nombre = "Elie",
                    txt_apellido = "Vargas",
                    nro_doc = "1234321",
                    cod_rol = 1,
                    sn_activo = 1

                },
                new UserModel() 
                {
                    cod_usuario = 2,
                    txt_user = "userText",
                    txt_password = "Text1",
                    txt_nombre = "Eliezer",
                    txt_apellido = "Gomez",
                    nro_doc = "1234321",
                    cod_rol = 2,
                    sn_activo = 1
                }
                
            };
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
