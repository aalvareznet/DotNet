using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal_UI.Models
{
    public class Reservaciones
    {
        [Display(Name = "Id Reservacion")]
        [DataType(DataType.Text)]
        [Required]
        public int TN_NumReservacion { get; set; }

        [Display(Name = "Id Cliente")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El id del cliente no debe estar vacio")]
        public int TN_IdCliente { get; set; }

        [Display(Name = "Id Mesa")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El id de la mesa no debe estar vacio")]
        public int TN_IdMesa { get; set; }

        [Display(Name = "Id Menu")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El id del menu no debe estar vacio")]
        public int TN_IdMenu { get; set; }

        [Display(Name = "Cantidad")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La cantidad de personas no debe estar vacio")]
        public int TN_Cantidad { get; set; }

        [Display(Name = "Fecha Reservacion")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "La fecha de reservacion no debe estar vacia")]
        public System.DateTime TF_FecReserva { get; set; }

    }
}