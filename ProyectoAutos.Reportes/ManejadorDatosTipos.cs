using ProyectoAutos.Entidades.DTOs.Tipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDatosTipos
    {
        internal AutosDataSet GetDatosTipos(List<TipoDto> lista)
        {
            AutosDataSet ds = new AutosDataSet();
            //lista.ForEach(m =>
            //ds.Tables["MarcasDataTable"].Rows.Add(m.Nombre));
            foreach (var t in lista)
            {
                ds.Tables["TiposDataTable"].Rows.Add(t.Descripcion);
            }
            return ds;
        }
    }
}
