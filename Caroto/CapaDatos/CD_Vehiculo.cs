using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class CD_Vehiculo
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarV()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarBD(string matricula, int idgamma)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select matricula,Id_Gamma from Vehiculo where matricula = " + "'" + matricula + "'" + " AND " + " Id_Gamma = " + "'" + idgamma + "'";
            comando.CommandTimeout = 2;
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarV(string matricula, int idgamma)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@idgamma", idgamma);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarV(string matricula, int idgamma)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@idgamma", idgamma);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarV(string matricula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
