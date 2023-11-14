using InscripcionUsuarioEjemploWebAsp.Metodos;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InscripcionUsuarioEjemploWebAsp.Controllers
{

    public class UsuariosController : Controller
    {
       

        // GET: Usuarios
        public ActionResult Index()
        {
            var api = new Api();
            var respuesta = api.Get("api/v1/usuarios-controller/lista-usuario"); 
            if (respuesta != null)
            {
                   return View(respuesta);
            }
            return View();
        }
    }
}