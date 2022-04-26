using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Gamma
    {
        private CD_Gamma objetoCD = new CD_Gamma();
        public DataTable MostrarGamma()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarG();
            return tabla;
        }
    }
}
