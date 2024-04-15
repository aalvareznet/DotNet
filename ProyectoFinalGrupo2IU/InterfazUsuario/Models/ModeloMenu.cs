using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterfazUsuario.Models
{
    public class ModeloMenu
    {
        [Display(Name = "Id Menu")]
        [Required]
        public int TN_IdMenu { get; set; }

        [Display(Name = "Descripcion del Menu")]
        [Required(ErrorMessage = "La descripcion del menu no puede estar vacia")]
        [MinLength(3, ErrorMessage = "La descripcion del menu debe tener al menos 3 caracteres")]
        [MaxLength(50, ErrorMessage = "La descripcion del menu no puede tener mas de 50 caracteres")]
        public string TC_DscMenu { get; set; }

        [Display(Name = "Tipo de Menu")]
        [Required(ErrorMessage = "El tipo de menu no puede estar vacio")]
        public int TN_IdTipoMenu { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio del menu no puede estar vacio")]
        public decimal TD_Precio { get; set; }
    }
}