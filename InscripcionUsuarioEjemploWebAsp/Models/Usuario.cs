using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InscripcionUsuarioEjemploWebAsp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }

    public class ListaUsuarios
    {
        public List<Usuario> Data { get; set; }
    }


}