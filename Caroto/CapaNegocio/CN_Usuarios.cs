using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();
        public DataTable MostrarUsu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable ComprobarUsu(string correo, string contraseña)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarBD(correo, contraseña);
            return tabla;
        }
        public void InsertarUsu(string correo, string contraseña)
        {
            objetoCD.Insertar(correo, contraseña);
        }

        public void EditarUsu(string correo, string contraseña)
        {
            objetoCD.Editar(correo, contraseña);
        }
        public void EliminarUsu(string correo)
        {
            objetoCD.Eliminar(correo);
        }
    }
}
