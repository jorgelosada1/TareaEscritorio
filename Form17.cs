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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double l1 = Convert.ToDouble(L1.Text);
            double l2 = Convert.ToDouble(L2.Text);
            double l3 = Convert.ToDouble(L3.Text);

            string tipoTriangulo;

            if (l1 == l2 && l2 == l3)
            {
                tipoTriangulo = "Equilátero";
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                tipoTriangulo = "Isósceles";
            }
            else
            {
                tipoTriangulo = "Escaleno";
            }
            Resultado.Text = tipoTriangulo;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            L1.Text = "";
            L2.Text = "";
            L3.Text = "";
            Resultado.Text = "";

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
