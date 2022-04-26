using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caroto.Models
{
    public class GammaViewModel
    {
        [Display(Name = "Gama Baja")]
        [DataType(DataType.Text)]
        public string Title1 { get; set; }

        [Display(Name = "Gama Media")]
        [DataType(DataType.Text)]
        public string Title2 { get; set; }

        [Display(Name = "Gama Alta")]
        [DataType(DataType.Text)]
        public string Title3 { get; set; }
    }
}
