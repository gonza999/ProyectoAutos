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
    public partial class MenuPrincipalForm : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SalirMetroTile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MarcasMetroTile_Click(object sender, EventArgs e)
        {
            MarcasForm frm = new MarcasForm();
            frm.ShowDialog(this);
        }
    }
}
