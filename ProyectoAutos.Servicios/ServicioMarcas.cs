using ProyectoAutos.Datos;
using ProyectoAutos.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutos.Servicios
{
    public class ServicioMarcas
    {
        private readonly RepositorioMarcas repositorio;
        public ServicioMarcas()
        {
            repositorio = new RepositorioMarcas();
        }

        public List<Marca> GetMarcas()
        {
            return repositorio.GetMarcas();
        }

        public void Borrar(int marcaId)
        {
            repositorio.Borrar(marcaId);
        }

        public void Editar(Marca marca)
        {
            repositorio.Editar(marca);
        }

        public void Nuevo(Marca marca)
        {
            repositorio.Nuevo(marca);
        }
    }
}
