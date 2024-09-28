using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double nacimiento = Convert.ToDouble(NACIMIENTO.Text);
            double actual = Convert.ToDouble(ACTUAL.Text);

            double E = actual - nacimiento;
            if (E > 17)
            {
                MENSAJE.Text = "Debe de inscribirse al SIMO";
            }
            else
            {
                MENSAJE.Text = "No debe de inscribirse al SIMO";
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            NACIMIENTO.Text = "";
            ACTUAL.Text = "";
            MENSAJE.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
