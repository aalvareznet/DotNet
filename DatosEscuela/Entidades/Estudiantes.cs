using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEscuela.Entidades
{
    public class Estudiantes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public int Grado { get; set; }
        public int Seccion { get; set; }
        [ForeignKey("ProfesorGuiaID")]
        public Profesores? ProfesorGuia { get; set; }
        public int ProfesorGuiaID { get; set; }
    }
}

