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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double ladoa = Convert.ToDouble(LadoA.Text);
            double ladob = Convert.ToDouble(LadoB.Text);
            double ladoc = Convert.ToDouble(LadoC.Text);

            double LS = (ladoa + ladob + ladoc) / 2;
            double AT = (LS * (LS - ladoa) * (LS - ladob) * (LS - ladoc));
            double resultado = Math.Pow(AT, 0.5);


            Resultado.Text = resultado.ToString();


        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LadoA.Text = "";
            LadoB.Text = "";
            LadoC.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
