using DatosEscuela.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEscuela
{
    public class ContextoEscuela : DbContext
    {
        public ContextoEscuela(DbContextOptions<ContextoEscuela> options) 
            : base(options)
        {
        }

        public DbSet<Materias> Materias { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
    }
    
}
