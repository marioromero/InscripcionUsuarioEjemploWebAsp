using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InscripcionUsuarioEjemploWebAsp.Models
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public bool EsActivo { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }

    }
}