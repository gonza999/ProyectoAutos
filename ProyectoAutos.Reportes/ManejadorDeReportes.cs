using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.DTOs.Tipo;
using System.Collections.Generic;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDeReportes
    {
        public ManejadorDeReportes()
        {

        }

        public MarcasReporte GetReporteGeneralMarcas(List<MarcaDto> lista)
        {
            MarcasReporte rpt = new MarcasReporte();
            ManejadorDatosMarcas manejadorDatos = new ManejadorDatosMarcas();
            AutosDataSet ds = manejadorDatos.GetDatosMarcas(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
        public TiposReporte GetReporteGeneralTipos(List<TipoDto> lista)
        {
            TiposReporte rpt = new TiposReporte();
            ManejadorDatosTipos manejadorDatos = new ManejadorDatosTipos();
            AutosDataSet ds = manejadorDatos.GetDatosTipos(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
