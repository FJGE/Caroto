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
        [Display(Name = "Gama Baja - 10.000€")]
        [DataType(DataType.Text)]
        public string GamaBaja { get; set; }

        [Display(Name = "Gama Media - 20.000€")]
        [DataType(DataType.Text)]
        public string GamaMedia { get; set; }

        [Display(Name = "Gama Alta - 30.000€")]
        [DataType(DataType.Text)]
        public string GamaAlta { get; set; }

        public List<Gama> CochesAltos = new List<Gama>();
        public List<Gama> CochesMedios = new List<Gama>();
        public List<Gama> CochesBajos = new List<Gama>();

        public List<Gama> MotosAltas = new List<Gama>();
        public List<Gama> MotosMedias = new List<Gama>();
        public List<Gama> MotosBajas = new List<Gama>();

        public List<Gama> PiezasMoto = new List<Gama>();
        public List<Gama> PiezasCoche = new List<Gama>();
    }
}
