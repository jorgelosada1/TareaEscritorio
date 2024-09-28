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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(Numero.Text);

            string resultadoRomano = "";

            switch (numero)
            {
                case 1:
                    resultadoRomano = "I";
                    break;
                case 2:
                    resultadoRomano = "II";
                    break;
                case 3:
                    resultadoRomano = "III";
                    break;
                case 4:
                    resultadoRomano = "IV";
                    break;
                case 5:
                    resultadoRomano = "V";
                    break;
                case 6:
                    resultadoRomano = "VI";
                    break;
                case 7:
                    resultadoRomano = "VII";
                    break;
                case 8:
                    resultadoRomano = "VIII";
                    break;
                case 9:
                    resultadoRomano = "IX";
                    break;
                case 10:
                    resultadoRomano = "X";
                    break;
                default:
                    resultadoRomano = "Número fuera de rango (1-10)";
                    break;
            }

            Romano.Text = resultadoRomano;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Numero.Text = "";
            Romano.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
