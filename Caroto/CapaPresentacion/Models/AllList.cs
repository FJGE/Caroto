using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Caroto.Models
{
    public class AllList
    {
        public List<GammaViewModel> CochesAltos = new List<GammaViewModel>();
        public List<GammaViewModel> CochesMedios = new List<GammaViewModel>();
        public List<GammaViewModel> CochesBajos = new List<GammaViewModel>();

        public List<GammaViewModel> MotosAltas = new List<GammaViewModel>();
        public List<GammaViewModel> MotosMedias = new List<GammaViewModel>();
        public List<GammaViewModel> MotosBajas = new List<GammaViewModel>();
    }
}
