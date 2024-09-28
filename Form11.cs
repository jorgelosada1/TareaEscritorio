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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double aba = Convert.ToDouble(ABA.Text);
            double abb = Convert.ToDouble(ABB.Text);
            double orda = Convert.ToDouble(ORDA.Text);
            double ordb = Convert.ToDouble(ORDB.Text);

            double D = Math.Pow(Math.Pow(abb - aba, 2) + Math.Pow(ordb - orda, 2), 0.5);

            Resultado.Text = D.ToString();

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            ABA.Text = "";
            ABB.Text = "";
            ORDA.Text = "";
            ORDB.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
