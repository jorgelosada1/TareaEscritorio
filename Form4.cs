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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Velocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double velocidad = Convert.ToDouble(Velocidad.Text);
            double tiempo = Convert.ToDouble(Tiempo.Text);


            double resultado = velocidad * tiempo;


            Resultado.Text = resultado.ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Velocidad.Text = "";
            Tiempo.Text = "";
            Resultado.Text = "";
        }
    }
}
