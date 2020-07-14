using ProyectoAutos.Entidades.DTOs.Marca;
using System.Collections.Generic;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDatosMarcas
    {
        public AutosDataSet GetDatosMarcas(List<MarcaDto> lista)
        {
            AutosDataSet ds = new AutosDataSet();
            //lista.ForEach(m =>
            //ds.Tables["MarcasDataTable"].Rows.Add(m.Nombre));
            foreach (var m in lista)
            {
                ds.Tables["MarcasDataTable"].Rows.Add(m.Nombre);
            }
            return ds;
        }
    }
}
