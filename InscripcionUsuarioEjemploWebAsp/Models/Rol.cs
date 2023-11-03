using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InscripcionUsuarioEjemploWebAsp.Models
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}