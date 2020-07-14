using MetroFramework;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Entidades.Mapas;
using ProyectoAutos.Presentacion.Helpers;
using ProyectoAutos.Reportes;
using ProyectoAutos.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoAutos.Presentacion
{
    public partial class MarcasForm : MetroFramework.Forms.MetroForm
    {
        private ServicioMarcas servicio;
        List<MarcaDto> lista;
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
            try
            {
                servicio = new ServicioMarcas();
                LoadRegistros();
            }
            catch (Exception ex)
            {
                Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
            }
        }

        private void LoadRegistros()
        {
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

        private void SetearFila(DataGridViewRow r, MarcaDto marca)
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
                MarcaDto marca = (MarcaDto)r.Tag;
                DialogResult dr = Helper.Helper.Mensaje(this, $"Desea borrar la marca {marca.Nombre}?");
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(marca.MarcaId);
                        DatosMetroGrid.Rows.Remove(r);
                        Helper.Helper.Mensaje(this, "Registro borrado", TipoDeCuadro.Success);
                    }
                    catch (Exception ex)
                    {
                        Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                MarcaDto marcaDto = (MarcaDto)r.Tag;
                //MarcaDto marcaClon = (MarcaDto)marca.Clone();
                MarcasAEForm frm = new MarcasAEForm();
                frm.Text = "Editar";
                frm.SetMarca(marcaDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        marcaDto = frm.GetMarca();
                        if (!servicio.Existe(marcaDto))
                        {
                            servicio.Editar(marcaDto);
                            SetearFila(r, marcaDto);
                            Helper.Helper.Mensaje(this, "Registro editado", TipoDeCuadro.Success);
                        }
                        else
                        {
                            //SetearFila(r, marcaClon);
                            LoadRegistros();
                            Helper.Helper.Mensaje(this, "Registro repetido", TipoDeCuadro.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        //SetearFila(r, marcaClon);
                        LoadRegistros();
                        Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
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
                    MarcaDto marcaDto = frm.GetMarca();
                    if (!servicio.Existe(marcaDto))
                    {
                        servicio.Agregar(marcaDto);
                        var r = ConstruirFila();
                        SetearFila(r, marcaDto);
                        AgregarFila(r);
                        Helper.Helper.Mensaje(this, "Registro agregado", TipoDeCuadro.Success);

                    }
                    else
                    {
                        Helper.Helper.Mensaje(this, "Registro repetido", TipoDeCuadro.Error);
                    }
                }
                catch (Exception ex)
                {
                    Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
                }
            }
        }

        private void ReporteMetroButton_Click(object sender, EventArgs e)
        {
            lista = servicio.GetMarcas();
            ManejadorDeReportes manejador = new ManejadorDeReportes();
            MarcasReporte rpt = manejador.GetReporteGeneralMarcas(lista);
            ReportesForm frm = new ReportesForm();
            frm.SetReporte(rpt);
            frm.ShowDialog(this);
        }
    }
}
