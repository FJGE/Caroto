using Caroto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caroto.Models
{
    public class VehiculoViewModel
    {
        [Display(Name = "Elija su Vehiculo")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
    }
}
