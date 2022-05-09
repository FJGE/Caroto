using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.Configuration.Json;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion;
        private bool Isconected = false;
        public SqlConnection AbrirConexion()
        {
            if (!Isconected)
            {
                createConection();
                Isconected = true;
            }

            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        private void createConection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var db = builder.Build().GetSection("ConnectionStrings").GetSection("BasedeDatos2").Value;

            Conexion = new SqlConnection(db);
        }
    }
}