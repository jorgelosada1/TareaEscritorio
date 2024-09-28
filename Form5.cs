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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(Nota1.Text);
            double nota2 = Convert.ToDouble(Nota2.Text);
            double nota3 = Convert.ToDouble(Nota3.Text);

            double resultado = (nota1 + nota2 + nota3) / 3;

            Resultado.Text = resultado.ToString();

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nota1.Text = "";
            Nota2.Text = "";
            Nota3.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
