using ProyectoAutos.Entidades.DTOs.Tipo;
using ProyectoAutos.Entidades.Entities;
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
    public partial class TiposAEForm : MetroFramework.Forms.MetroForm
    {
        public TiposAEForm()
        {
            InitializeComponent();
        }
        private TipoDto tipoDto;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDto != null)
            {
                tipoMetroTextBox.Text = tipoDto.Descripcion;
            }
        }
        internal TipoDto GetTipo()
        {
            return tipoDto;
        }

        private void CancelarMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkeyMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDto == null)
                {
                    tipoDto = new TipoDto();
                }
                tipoDto.Descripcion = tipoMetroTextBox.Text;
                DialogResult=DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(tipoMetroTextBox.Text) &&
                string.IsNullOrWhiteSpace(tipoMetroTextBox.Text))
            {
                errorProvider1.SetError(tipoMetroTextBox,"Debe ingresar un Tipo");
                valido = false;
            }
            return valido;
        }

        internal void SetTipo(TipoDto tipoDto)
        {
            this.tipoDto = tipoDto;
        }
    }
}
