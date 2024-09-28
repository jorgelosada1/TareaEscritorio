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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double lunes = Convert.ToDouble(Lunes.Text);
            double martes = Convert.ToDouble(Martes.Text);
            double miercoles = Convert.ToDouble(Miercoles.Text);
            double jueves = Convert.ToDouble(Jueves.Text);
            double viernes = Convert.ToDouble(Viernes.Text);
            double sabado = Convert.ToDouble(Sabado.Text);

            double PT = (lunes + martes + miercoles + jueves + viernes + sabado);
            double PP = PT / 6;
            if (PP >= 100)
            {
                Incentivos.Text = "Recibira Incentivos";
            }
            else
            {
                Incentivos.Text = "No recibira Incentivos";
            }


        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Lunes.Text = "";
            Martes.Text = "";
            Miercoles.Text = "";
            Jueves.Text = "";
            Viernes.Text = "";
            Sabado.Text = "";
            Incentivos.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
