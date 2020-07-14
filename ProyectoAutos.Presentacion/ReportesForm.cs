using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportesForm : MetroFramework.Forms.MetroForm
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private ReportClass rpt;

        public void SetReporte(ReportClass rpt)
        {
            this.rpt = rpt;
            crystalReportViewer1.ReportSource = rpt;
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
