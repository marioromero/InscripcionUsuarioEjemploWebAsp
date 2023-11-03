using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InscripcionUsuarioEjemploWebAsp.Models
{
    public class InscripcionUsuarioEjemploWebAspContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4U48PKE;Database=inscripciones;Trusted_Connection=True;");
        }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}