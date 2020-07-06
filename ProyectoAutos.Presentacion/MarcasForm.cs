using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAutos.Presentacion
{
    public partial class MarcasForm : MetroFramework.Forms.MetroForm
    {
        private ServicioMarcas servicio;
        List<Marca> lista;
        public MarcasForm()
        {
            InitializeComponent();
        }

        private void CerrarMetroButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        
        private void MarcasForm_Load(object sender, System.EventArgs e)
        {
            servicio = new ServicioMarcas();
            lista = servicio.GetMarcas();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosMetroGrid.Rows.Clear();
            foreach (var marca in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r,marca);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Marca marca)
        {
            r.Cells[cmnMarca.Index].Value = marca.Nombre;
            r.Tag = marca;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosMetroGrid);
            return r;
        }
    }
}
