using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoAutos.Datos
{
    public class ConexionBD
    {
        private string cadenaConexion;
        private SqlConnection conexion;

        public ConexionBD()
        {
            try
            {
                cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;

        }
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
