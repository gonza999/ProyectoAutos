using MetroFramework;
using ProyectoAutos.Entidades.DTOs.Tipo;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Presentacion.Helper;
using ProyectoAutos.Presentacion.Helpers;
using ProyectoAutos.Reportes;
using ProyectoAutos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutos.Presentacion
{
    public partial class TiposForm : MetroFramework.Forms.MetroForm
    {
        public TiposForm()
        {
            InitializeComponent();
        }
        private ServicioTipos servicio;
        private List<TipoDto> lista;
        private void TiposForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioTipos();
                LoadRegistros();
            }
            catch (Exception ex)
            {
                Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
            }

        }

        private void LoadRegistros()
        {
            lista = servicio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosMetroGrid.Rows.Clear();
            foreach (var tipoDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDto tipoDto)
        {
            r.Cells[cmnTipo.Index].Value = tipoDto.Descripcion;
            r.Tag = tipoDto;
        }
        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosMetroGrid);

            return r;
        }

        private void CerrarMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            TiposAEForm frm = new TiposAEForm();
            frm.Text = "Nuevo";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    TipoDto tipoDto = frm.GetTipo();
                    if (!servicio.Existe(tipoDto))
                    {
                        servicio.Agregar(tipoDto);
                        var r = ConstruirFila();
                        SetearFila(r, tipoDto);
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
                    Helper.Helper.Mensaje(this,ex.Message,TipoDeCuadro.Error);
                }
            }
        }

        private void DatosMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                var r = DatosMetroGrid.SelectedRows[0];
                var tipoDto = (TipoDto) r.Tag;
                DialogResult dr = Helper.Helper.Mensaje(this,
                    $"Desea dar de baja el tipo {tipoDto.Descripcion}?");
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(tipoDto.TipoId);
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
                var r = DatosMetroGrid.SelectedRows[0];
                var tipoDto = (TipoDto)r.Tag;
                TiposAEForm frm = new TiposAEForm();
                frm.Text = "Editar";
                frm.SetTipo(tipoDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipoDto = frm.GetTipo();
                        if (!servicio.Existe(tipoDto))
                        {
                            servicio.Editar(tipoDto);
                            SetearFila(r, tipoDto);
                            Helper.Helper.Mensaje(this, "Registro editado", TipoDeCuadro.Success);

                        }
                        else
                        {
                            LoadRegistros();
                            Helper.Helper.Mensaje(this, "Registro repetido", TipoDeCuadro.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        LoadRegistros();
                        Helper.Helper.Mensaje(this, ex.Message, TipoDeCuadro.Error);
                    }
                }
            }
        }

        private void ReporteMetroButton_Click(object sender, EventArgs e)
        {
            lista = servicio.GetLista();
            ManejadorDeReportes manejador = new ManejadorDeReportes();
            TiposReporte rpt = manejador.GetReporteGeneralTipos(lista);
            ReportesForm frm = new ReportesForm();
            frm.SetReporte(rpt);
            frm.ShowDialog(this);
        }
    }
}
