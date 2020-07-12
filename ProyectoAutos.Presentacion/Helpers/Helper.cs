using MetroFramework;
using ProyectoAutos.Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutos.Presentacion.Helper
{
    public class Helper
    {
        public static void Mensaje(Form owner, string mensaje, TipoDeCuadro tipo)
        {
            switch (tipo)
            {
                case TipoDeCuadro.Success:
                    MetroMessageBox.Show(owner, mensaje, "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case TipoDeCuadro.Error:
                    MetroMessageBox.Show(owner, mensaje, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                case TipoDeCuadro.Warning:
                    MetroMessageBox.Show(owner, mensaje, "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }
        }
        public static DialogResult Mensaje(Form owner, string mensaje)
        {
            return MetroMessageBox.Show(owner, mensaje, "Confirmar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
        }

    }
}
