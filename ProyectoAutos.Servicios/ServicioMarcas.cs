using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutos.Servicios
{
    public class ServicioMarcas
    {
        private RepositorioMarcas repositorio;
        private ConexionBD conexionBD;
        public ServicioMarcas()
        {
        }

        public List<MarcaDto> GetMarcas()
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioMarcas(conexionBD.AbrirConexion());
            var lista= repositorio.GetMarcas();
            conexionBD.CerrarConexion();
            return lista;
        }

        public void Borrar(int marcaId)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioMarcas(conexionBD.AbrirConexion());
            repositorio.Borrar(marcaId);
            conexionBD.CerrarConexion();
        }

        public void Editar(MarcaDto marcaDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioMarcas(conexionBD.AbrirConexion());
            var marca = Mapeador.ConvertirAMarca(marcaDto);
            repositorio.Editar(marca);
            conexionBD.CerrarConexion();
        }

        public void Agregar(MarcaDto marcaDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioMarcas(conexionBD.AbrirConexion());
            var marca = Mapeador.ConvertirAMarca(marcaDto);
            repositorio.Agregar(marca);
            conexionBD.CerrarConexion();
        }

        public bool Existe(MarcaDto marcaDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioMarcas(conexionBD.AbrirConexion());
            bool existe=repositorio.Existe(marcaDto);
            conexionBD.CerrarConexion();
            return existe;
        }
    }
}
