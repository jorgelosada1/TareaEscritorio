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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CAF_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(Temperatura.Text);

            double resultado = ((temp * 9) / 5) + 32;

            Resultado.Text = resultado.ToString();

        }

        private void FAC_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(Temperatura.Text);

            double resultado = ((temp - 32) * 0.5556);

            Resultado.Text = resultado.ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Temperatura.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
