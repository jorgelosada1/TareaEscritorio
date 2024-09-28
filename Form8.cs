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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double horas = Convert.ToDouble(Horas.Text);
            double tarifa = Convert.ToDouble(Tarifa.Text);

            double resultado = horas * tarifa;

            Total.Text = resultado.ToString();


        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Horas.Text = "";
            Tarifa.Text = "";
            Total.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
