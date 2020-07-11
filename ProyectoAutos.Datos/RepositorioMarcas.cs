using ProyectoAutos.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutos.Datos
{
    public class RepositorioMarcas
    {
        private readonly SqlConnection conexion;
        public RepositorioMarcas()
        {
            string cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            conexion = new SqlConnection(cadenaDeConexion);
        }
        public List<Marca> GetMarcas()
        {
            List<Marca> lista = new List<Marca>() ;
            try
            {

                conexion.Open();
                var cadenaDeComando = "SELECT MarcaId,NombreMarca FROM Marcas ";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Marca marca = ConstruirMarca(reader);
                    lista.Add(marca);
                }
                reader.Close();
                conexion.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Nuevo(Marca marca)
        {
            try
            {
                conexion.Open();
                var cadenaDeComando = "INSERT INTO Marcas VALUES (@marca)";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                comando.Parameters.AddWithValue("@marca",marca.Nombre);
                comando.ExecuteNonQuery();
                cadenaDeComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaDeComando,conexion);
                marca.MarcaId = (int)(decimal)comando.ExecuteScalar();
                conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message) ;
            }
        }

        public void Editar(Marca marca)
        {
            try
            {
                conexion.Open();
                var cadenaDeConexion = "UPDATE Marcas SET NombreMarca=@marca WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaDeConexion,conexion);
                comando.Parameters.AddWithValue("@marca",marca.Nombre);
                comando.Parameters.AddWithValue("@id",marca.MarcaId);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int marcaId)
        {
            try
            {
                conexion.Open();
                var cadenaDeComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                comando.Parameters.AddWithValue("@id",marcaId);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Marca ConstruirMarca(SqlDataReader reader)
        {
            return new Marca
            {
                MarcaId = reader.GetInt32(0),
                Nombre=reader.GetString(1)
            };
        }
    }
}
