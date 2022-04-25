using CapaPresentacion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caroto.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(16, ErrorMessage = "Longitud entre 8 y 16 caracteres.",
                      MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Display(Name = "Elija su Vehiculo")]
        [DataType(DataType.Text)]
        public string Title{ get; set; }

        public List<Vehiculo> ve = new List<Vehiculo>();
    }
}
