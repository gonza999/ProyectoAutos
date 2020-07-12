using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;
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
        public RepositorioMarcas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }
        public List<MarcaDto> GetMarcas()
        {
            List<MarcaDto> lista = new List<MarcaDto>() ;
            try
            {
                var cadenaDeComando = "SELECT MarcaId,NombreMarca FROM Marcas ";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Marca marca = ConstruirMarca(reader);
                    MarcaDto marcaDto = Mapeador.ConvertirAMarcaDto(marca);
                    lista.Add(marcaDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Marca marca)
        {
            try
            {
                var cadenaDeComando = "INSERT INTO Marcas VALUES (@marca)";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                comando.Parameters.AddWithValue("@marca",marca.Nombre);
                comando.ExecuteNonQuery();
                cadenaDeComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaDeComando,conexion);
                marca.MarcaId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message) ;
            }
        }

        public bool Existe(MarcaDto marcaDto)
        {
            try
            {
                if (marcaDto.MarcaId == 0)
                {
                    string cadenaDeComando = "SELECT MarcaId,NombreMarca FROM Marcas WHERE NombreMarca=@nombre";
                    var comando = new SqlCommand(cadenaDeComando, conexion);
                    comando.Parameters.AddWithValue("@nombre", marcaDto.Nombre);
                    var reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaDeComando = "SELECT MarcaId,NombreMarca FROM Marcas WHERE NombreMarca=@nombre AND MarcaId<>@id";
                    var comando = new SqlCommand(cadenaDeComando, conexion);
                    comando.Parameters.AddWithValue("@nombre", marcaDto.Nombre);
                    comando.Parameters.AddWithValue("@id", marcaDto.MarcaId);
                    var reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Marca marca)
        {
            try
            {
                var cadenaDeConexion = "UPDATE Marcas SET NombreMarca=@marca WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaDeConexion,conexion);
                comando.Parameters.AddWithValue("@marca",marca.Nombre);
                comando.Parameters.AddWithValue("@id",marca.MarcaId);
                comando.ExecuteNonQuery();
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
                var cadenaDeComando = "DELETE FROM Marcas WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaDeComando,conexion);
                comando.Parameters.AddWithValue("@id",marcaId);
                comando.ExecuteNonQuery();
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
