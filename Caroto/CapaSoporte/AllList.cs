using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte
{
    public class AllList
    {
        [Display(Name = "Gama Baja - 500€")]
        [DataType(DataType.Text)]
        public string GamaBaja { get; set; }

        [Display(Name = "Gama Media - 1000€")]
        [DataType(DataType.Text)]
        public string GamaMedia { get; set; }

        [Display(Name = "Gama Alta - 1500€")]
        [DataType(DataType.Text)]
        public string GamaAlta { get; set; }

        public List<Gama> CochesAltos = new List<Gama>();
        public List<Gama> CochesMedios = new List<Gama>();
        public List<Gama> CochesBajos = new List<Gama>();

        public List<Gama> MotosAltas = new List<Gama>();
        public List<Gama> MotosMedias = new List<Gama>();
        public List<Gama> MotosBajas = new List<Gama>();

        public List<Gama> PiezasBajas = new List<Gama>();
        public List<Gama> PiezasMedias = new List<Gama>();
        public List<Gama> PiezasAltas = new List<Gama>();
    }
}
