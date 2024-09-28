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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double cant = Convert.ToDouble(Cantidad.Text);
            double MG = cant * 1.024;
            double MD = MG / 1.44;


            Resultado.Text = MD.ToString();

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Cantidad.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
