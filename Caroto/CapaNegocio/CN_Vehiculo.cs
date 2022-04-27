using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Vehiculo
    {
        private CD_Vehiculo objetoCD = new CD_Vehiculo();
        public DataTable MostrarVeh()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarV();
            return tabla;
        }
        public DataTable ComprobarVeh(string matricula, int idgamma)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarBD(matricula, idgamma);
            return tabla;
        }
        public void InsertarVeh(string matricula, int idgamma)
        {
            objetoCD.InsertarV(matricula, idgamma);
        }

        public void EditarVeh(string matricula, int idgamma)
        {
            objetoCD.EditarV(matricula, idgamma);
        }
        public void EliminarVeh(string matricula)
        {
            objetoCD.EliminarV(matricula);
        }
    }
}
