using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caroto.Models
{
    public class GammaViewModel
    {
        [Display(Name = "Elija su Vehiculo")]
        [DataType(DataType.Text)]
        public string TitleMenuVehiculo { get; set; }

        public string matricula { get; set; }
        public int id { get; set; }
    }
}
