using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte
{
    public class Principal
    {
        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Dirección de Correo incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(16, ErrorMessage = "Longitud entre 8 y 16 caracteres.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        public string Caroto { get; set; }
        public string Descripcion { get; set; }
        public string Iniciar_Sesion { get; set; }
        public string Productos { get; set; }
        public string Sobre_Nosotros { get; set; }
        public string Descripcion2 { get; set; }

        public List<Secundaria> secun { get; set; }
    }
}
