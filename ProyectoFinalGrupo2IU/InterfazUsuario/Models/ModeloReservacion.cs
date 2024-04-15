using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterfazUsuario.Models
{
    public class ModeloReservacion
    {
        [Display(Name = "Numero Reservacion")]
        [Required]
        public int TN_NumReservacion { get; set; }

        [Display(Name = "Codigo de cliente")]
        [Required]
        public int TN_IdCliente { get; set; }

        [Display(Name = "Id Mesa")]
        [Required]
        public int TN_IdMesa { get; set; }

        [Display(Name = "Id Menu")]
        [Required]
        public int TN_IdMenu { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "La cantidad no puede estar vacia")]
        public int TN_Cantidad { get; set; }

        [Display(Name = "Fecha de Reservacion")]
        [Required(ErrorMessage = "La fecha de reservacion no puede estar vacia")]
        [DataType(DataType.DateTime)]
        [DisplayFormatAttribute(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime TF_FecReserva { get; set; }
    }
}