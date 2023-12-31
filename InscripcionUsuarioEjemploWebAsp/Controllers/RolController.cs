﻿using InscripcionUsuarioEjemploWebAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InscripcionUsuarioEjemploWebAsp.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            try
            {
                using (var context = new InscripcionUsuarioEjemploWebAspContext())
                {
                    return View(context.Roles.ToList());
                }
            }
            catch (System.IO.FileLoadException ex)
            {
                throw new Exception("Error al cargar el archivo o ensamblado 'System.Threading.Tasks.Extensions, Version=4.2.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51' ni una de sus dependencias. La definición del manifiesto del ensamblado no coincide con la referencia al ensamblado.", ex);
            }
        }

        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            using (var context = new InscripcionUsuarioEjemploWebAspContext())
            {
                return View(context.Roles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Rol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(Rol rol)
        {
            try
            {
                using (var context = new InscripcionUsuarioEjemploWebAspContext())
                {
                    context.Roles.Add(rol);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new InscripcionUsuarioEjemploWebAspContext())
            {
                return View(context.Roles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Rol rol)
        {
            try
            {
                using (var context = new InscripcionUsuarioEjemploWebAspContext())
                {
                    context.Entry(rol).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new InscripcionUsuarioEjemploWebAspContext())
            {
                return View(context.Roles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Rol/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var context = new InscripcionUsuarioEjemploWebAspContext())
                {
                    Rol rol = context.Roles.Where(x => x.Id == id).FirstOrDefault();
                    context.Roles.Remove(rol);
                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
