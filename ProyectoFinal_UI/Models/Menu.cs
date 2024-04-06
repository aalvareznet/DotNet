using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal_UI.Models
{
    public class Menu
    {
        [Display(Name = "Id Item")]
        [DataType(DataType.Text)]
        [Required]
        public int TN_IdMenu { get; set; }

        [Display(Name = "Descripcion")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La descripcion no debe estar vacia")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 caracteres")]
        public string TC_DscMenu { get; set; }

        [Display(Name = "Tipo Menu")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El tipo de menu no debe estar vacio")]
        [MinLength(1, ErrorMessage = "Minimo de 1 caracteres")]
        public int TN_IdTipoMenu { get; set; }

        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "El precio no debe estar vacia")]
        public decimal TD_Precio { get; set; }
    }
}