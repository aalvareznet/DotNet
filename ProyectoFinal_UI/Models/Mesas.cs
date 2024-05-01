using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal_UI.Models
{
    public class Mesas
    {
        [Display(Name = "Id Mesa")]
        [DataType(DataType.Text)]
        [Required]
        public int TN_IdMesa { get; set; }

        [Display(Name = "Descripcion")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La descripcion no debe estar vacia")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 caracteres")]
        public string TC_DscMesa { get; set; }
    }
}