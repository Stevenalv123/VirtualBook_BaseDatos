using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio.")]
        public string Correo_Electronico { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        public string Contraseña { get; set; }
    }
}
