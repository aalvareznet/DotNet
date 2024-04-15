using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterfazUsuario.Models
{
    public class ModeloMesas
    {
        [Display(Name = "Id Mesa")]
        [Required]
        public int TN_IdMesa { get; set; }

        [Display(Name = "Descripcion de la Mesa")]
        [Required(ErrorMessage = "La descripcion de la mesa no puede estar vacia")]
        [MinLength(3, ErrorMessage = "La descripcion de la mesa debe tener al menos 3 caracteres")]
        [MaxLength(50, ErrorMessage = "La descripcion de la mesa no puede tener mas de 50 caracteres")]
        public string TC_DscMesa { get; set; }
    }
}