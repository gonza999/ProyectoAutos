using MetroFramework;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using System;
using System.Windows.Forms;

namespace ProyectoAutos.Presentacion
{
    public partial class MarcasAEForm : MetroFramework.Forms.MetroForm
    {
        public MarcasAEForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (marca!=null)
            {
                marcaMetroTextBox.Text = marca.Nombre;
            }
        }
        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        private MarcaDto marca;
        internal void SetMarca(MarcaDto marca)
        {
            this.marca = marca;
        }

        internal MarcaDto GetMarca()
        {
            return marca;
        }

        private void OkeyMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca==null)
                {
                    marca = new MarcaDto();
                }
                marca.Nombre = marcaMetroTextBox.Text;
                DialogResult=DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(marcaMetroTextBox.Text.Trim())&& 
                string.IsNullOrWhiteSpace(marcaMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(marcaMetroTextBox,"Debe ingresar una marca");
            }
            return valido;
        }
    }
}
