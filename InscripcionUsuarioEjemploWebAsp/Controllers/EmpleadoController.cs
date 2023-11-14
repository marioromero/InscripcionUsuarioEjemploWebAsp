using InscripcionUsuarioEjemploWebAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InscripcionUsuarioEjemploWebAsp.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            try
            {
                using (var context = new InscripcionUsuarioEjemploWebAspContext())
                {
                    return View(context.Empleados.ToList());
                }
            }
            catch (System.IO.FileLoadException ex)
            {
                throw new Exception("error: ", ex);
            }
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            using (var context = new InscripcionUsuarioEjemploWebAspContext())
            {
                return View(context.Roles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
