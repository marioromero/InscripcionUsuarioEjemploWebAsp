using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InscripcionUsuarioEjemploWebAsp.Models
{
    public class Inscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }

        public int usuarioId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime fecha { get; set; }
        public string Comentarios { get; set; }
    }
}