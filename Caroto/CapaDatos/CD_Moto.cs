using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Moto
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar(int gamma)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMotos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Gamma", gamma.ToString());
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
