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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double opcion = Convert.ToDouble(Opcion.Text);
            double monto = Convert.ToDouble(Monto.Text);

            double bonificacion = 0;
            double porcentaje = 0;


            if (monto >= 0 && monto < 1000)
            {
                porcentaje = 0;
                bonificacion = (porcentaje * monto) / 100;
            }
            else if (monto >= 1000 && monto < 5000)
            {
                porcentaje = 3;
                bonificacion = (porcentaje * monto) / 100;
            }
            else if (monto >= 5000 && monto < 20000)
            {
                porcentaje = 5;
                bonificacion = (porcentaje * monto) / 100;
            }
            else if (monto >= 20000)
            {
                porcentaje = 8;
                bonificacion = (porcentaje * monto) / 100;
            }


            Porcentaje.Text = porcentaje.ToString();
            Total.Text = bonificacion.ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Opcion.Text = "";
            Porcentaje.Text = "";
            Monto.Text = "";
            Total.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
