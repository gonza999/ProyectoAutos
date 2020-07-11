using MetroFramework;
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
                SetearFila(r, marca);
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

        private void DatosMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                Marca marca = (Marca)r.Tag;
                DialogResult dr = MetroMessageBox.Show(this, $"Desea borrar la marca {marca.Nombre}?",
                    "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(marca.MarcaId);
                        DatosMetroGrid.Rows.Remove(r);
                        MetroMessageBox.Show(this, "Borrado con exito",
                    "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message,
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                Marca marca = (Marca)r.Tag;
                MarcasAEForm frm = new MarcasAEForm();
                frm.Text = "Editar";
                frm.SetMarca(marca);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        marca = frm.GetMarca();
                        servicio.Editar(marca);
                        SetearFila(r,marca);
                        MetroMessageBox.Show(this, "Editado con exito",
                    "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message,
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            MarcasAEForm frm = new MarcasAEForm();
            frm.Text = "Nuevo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    var marca = frm.GetMarca();
                    servicio.Nuevo(marca);
                    var r=ConstruirFila();
                    SetearFila(r,marca);
                    AgregarFila(r);
                    MetroMessageBox.Show(this, "Agregado con exito",
                "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message,
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
