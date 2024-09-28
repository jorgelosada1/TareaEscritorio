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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            N1.Text = "";
            N2.Text = "";
            N3.Text = "";
            Mayor.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(N1.Text);
            double n2 = Convert.ToDouble(N2.Text);
            double n3 = Convert.ToDouble(N3.Text);

            double mayor = Math.Max(n1, Math.Max(n2, n3));

            Mayor.Text = mayor.ToString();

        }
    }
}
