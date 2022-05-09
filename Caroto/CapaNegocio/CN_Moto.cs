using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Moto
    {
        enum TipoGamma : int { 
            Alta =3,
            Media=2,
            Baja =1
        }

        private CD_Moto objetoCD = new CD_Moto();
        public DataSet MostrarProd()
        {
            DataSet Ds = new DataSet();

            DataTable Alta = new DataTable();
            DataTable Media = new DataTable();
            DataTable Baja = new DataTable();

            Alta = objetoCD.Mostrar((int)TipoGamma.Alta);
            Media = objetoCD.Mostrar((int)TipoGamma.Media);
            Baja = objetoCD.Mostrar((int)TipoGamma.Baja);

            Ds.Tables.Add(Alta);
            Ds.Tables.Add(Media);
            Ds.Tables.Add(Baja);

            return Ds;
        }
    }
}
