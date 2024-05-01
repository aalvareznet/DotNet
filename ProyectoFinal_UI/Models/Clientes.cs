using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal_UI.Models
{
    public class Clientes
    {
        [Display(Name="Id Cliente")]
        [DataType(DataType.Text)]
        [Required]
        public int TN_IdCliente { get; set; }

        [Display(Name = "Nombre")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="El nombre del cliente no puede estar vacio")]
        [MinLength(2, ErrorMessage ="Minimo de 5 caracteres")]
        [MaxLength(40, ErrorMessage ="Maximo de 40 caracteres")]
        public string TC_Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El primer apellido del cliente no puede estar vacio")]
        [MinLength(2, ErrorMessage = "Minimo de 5 caracteres")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 caracteres")]
        public string TC_Ap1 { get; set; }

        [Display(Name = "Segundo Apellido")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El segundo apellido cliente no puede estar vacio")]
        [MinLength(2, ErrorMessage = "Minimo de 5 caracteres")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 caracteres")]
        public string TC_Ap2 { get; set; }

        [Display(Name = "Numero Telefono")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="El telefono electronico no puede estar vacio")]
        [MaxLength(8, ErrorMessage = "Maximo de 8 caracteres")]
        public string Tc_NumTelefonico { get; set; }

        [Display(Name = "Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="El correo del cliente no puede estar vacio")]
        [MinLength(2, ErrorMessage = "Minimo de 5 caracteres")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 caracteres")]
        public string TC_CorreoElectronico { get; set; }
    }
}