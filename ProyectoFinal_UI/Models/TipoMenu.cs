using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal_UI.Models
{
    public class TipoMenu
    {
        [Display(Name = "Id Tipo Menu")]
        [DataType(DataType.Text)]
        [Required]
        public int TN_IdTipoMenu { get; set; }

        [Display(Name = "Descripcion Tipo Menu")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="La descripcion no debe estar vacia")]
        [MinLength(5, ErrorMessage ="La descripcion de debe tener un minimo de 5 caracteres")]
        public string Tc_DscTipoMenu { get; set; }
    }
}