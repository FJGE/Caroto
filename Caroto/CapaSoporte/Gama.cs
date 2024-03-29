﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte
{
    public class Gama
    {
        [Display(Name = "Elija su Vehiculo")]
        [DataType(DataType.Text)]
        public string TitleMenuVehiculo { get; set; }

        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string matricula { get; set; }
        public string Imagen { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }
}
