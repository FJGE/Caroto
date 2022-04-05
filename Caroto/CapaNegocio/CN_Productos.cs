using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        public DataTable MostrarUsu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
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
