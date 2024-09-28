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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double primer = Convert.ToDouble(Primer.Text);
            double segundo = Convert.ToDouble(Segundo.Text);

            if (primer > segundo)
            {
                MENSAJE.Text = "El primer hermano es el mayor por:";
                double diferencia = primer - segundo;
                Años.Text = diferencia.ToString();
            }
            else {
                MENSAJE.Text = "El segundo hermano es el mayor por:";
                double diferencia = segundo - primer;
                Años.Text = diferencia.ToString();
            }

             
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {
            Primer.Text = "";
            Segundo.Text = "";
            MENSAJE.Text = "";
            Años.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
