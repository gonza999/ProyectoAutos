using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.DTOs.Tipo;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;
using System;
using System.Collections.Generic;

namespace ProyectoAutos.Servicios
{
    public class ServicioTipos
    {
        private RepositorioTipos repositorio;
        private ConexionBD conexionBD;

        public ServicioTipos()
        {
            
        }
        public List<TipoDto> GetLista()
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioTipos(conexionBD.AbrirConexion());
            var lista=repositorio.GetLista();
            conexionBD.CerrarConexion();
            return lista;
        }

        public void Agregar(TipoDto tipoDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioTipos(conexionBD.AbrirConexion());
            Tipo tipo = Mapeador.ConvertirATipo(tipoDto);
            repositorio.Agregar(tipo);
            conexionBD.CerrarConexion();
        }

        public bool Existe(TipoDto tipoDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioTipos(conexionBD.AbrirConexion());
            bool existe = repositorio.Existe(tipoDto);
            conexionBD.CerrarConexion();
            return existe;
        }
        public void Borrar(int tipoId)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioTipos(conexionBD.AbrirConexion());
            repositorio.Borrar(tipoId);
            conexionBD.CerrarConexion();
        }

        public void Editar(TipoDto tipoDto)
        {
            conexionBD = new ConexionBD();
            repositorio = new RepositorioTipos(conexionBD.AbrirConexion());
            Tipo tipo = Mapeador.ConvertirATipo(tipoDto);
            repositorio.Editar(tipo);
            conexionBD.CerrarConexion();
        }
    }
}
