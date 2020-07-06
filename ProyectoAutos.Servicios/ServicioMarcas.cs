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
    }
}
