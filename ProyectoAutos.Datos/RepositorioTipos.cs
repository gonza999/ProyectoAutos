using ProyectoAutos.Entidades.DTOs.Tipo;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoAutos.Datos
{
    public class RepositorioTipos
    {
        private readonly SqlConnection conexion;

        public RepositorioTipos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }
        public List<TipoDto> GetLista()
        {
            List<TipoDto> lista = new List<TipoDto>();
            try
            {
                var cadenaDeComando = "SELECT TipoId,Descripcion FROM Tipos";
                var comando = new SqlCommand(cadenaDeComando, conexion);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Tipo tipo = ConstruirTipo(reader);
                    TipoDto tipoDto = Mapeador.ConvertirATipoDto(tipo);
                    lista.Add(tipoDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDto tipoDto)
        {
            try
            {
                if (tipoDto.TipoId == 0)
                {
                    string cadenaDeComando = "SELECT TipoId,Descripcion FROM Tipos WHERE Descripcion=@desc";
                    var comando = new SqlCommand(cadenaDeComando, conexion);
                    comando.Parameters.AddWithValue("@desc", tipoDto.Descripcion);
                    var reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                else
                {
                    string cadenaDeComando = "SELECT TipoId,Descripcion FROM Tipos WHERE Descripcion=@desc AND TipoId<>@id";
                    var comando = new SqlCommand(cadenaDeComando, conexion);
                    comando.Parameters.AddWithValue("@desc", tipoDto.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipoDto.TipoId);
                    var reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Tipo tipo)
        {
            try
            {
                var cadenaDeComando = "UPDATE Tipos SET Descripcion=@desc WHERE TipoId=@id";
                var comando = new SqlCommand(cadenaDeComando, conexion);
                comando.Parameters.AddWithValue("@desc", tipo.Descripcion);
                comando.Parameters.AddWithValue("@id", tipo.TipoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoId)
        {
            try
            {
                var cadenaDeComando = "DELETE FROM Tipos WHERE TipoId=@id";
                var comando = new SqlCommand(cadenaDeComando, conexion);
                comando.Parameters.AddWithValue("@id", tipoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Tipo tipo)
        {
            try
            {
                var cadenaDeComando = "INSERT INTO Tipos VALUES (@descripcion)";
                var comando = new SqlCommand(cadenaDeComando, conexion);
                comando.Parameters.AddWithValue("@descripcion", tipo.Descripcion);
                comando.ExecuteNonQuery();
                cadenaDeComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaDeComando, conexion);
                tipo.TipoId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Tipo ConstruirTipo(SqlDataReader reader)
        {
            return new Tipo
            {
                TipoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }
    }
}
