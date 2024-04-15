using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterfazUsuario.Models
{
    public class ModeloCliente
    {
        [Display(Name = "Codigo de cliente")]
        [Required]
        public int TN_IdCliente { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre del cliente no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El nombre del cliente debe tener al menos 3 caracteres")]
        [MaxLength(50, ErrorMessage = "El nombre del cliente no puede tener mas de 50 caracteres")]
        public string TC_Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        [Required(ErrorMessage = "El apellido paterno del cliente no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El apellido paterno del cliente debe tener al menos 3 caracteres")]
        [MaxLength(50, ErrorMessage = "El apellido paterno del cliente no puede tener mas de 50 caracteres")]
        public string TC_Ap1 { get; set; }

        [Display(Name = "Apellido Materno")]
        [Required(ErrorMessage = "El apellido materno del cliente no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El apellido materno del cliente debe tener al menos 3 caracteres")]
        [MaxLength(50, ErrorMessage = "El apellido materno del cliente no puede tener mas de 50 caracteres")]
        public string TC_Ap2 { get; set; }


        [Display(Name = "Numero Telefonico")]
        [Required(ErrorMessage = "El numero telefonico del cliente no puede estar vacio")]
        [MinLength(8, ErrorMessage = "El numero telefonico del cliente debe tener al menos 8 caracteres")]
        public string Tc_NumTelefonico { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El correo electronico del cliente no puede estar vacio")]
        [MinLength(4, ErrorMessage = "El correo electronico del cliente debe tener al menos 4 caracteres")]
        [MaxLength(50, ErrorMessage = "El correo electronico del cliente no puede tener mas de 50 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string TC_CorreoElectronico { get; set; }
    }
}