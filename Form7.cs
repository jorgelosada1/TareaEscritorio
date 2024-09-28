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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void RI_TextChanged(object sender, EventArgs e)
        {

        }

        private void PF_TextChanged(object sender, EventArgs e)
        {


        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double partidosg = Convert.ToDouble(PartidosG.Text);
            double partidose = Convert.ToDouble(PartidosE.Text);

            double ppg = partidosg * 3;
            double ppe = partidose * 1;
            double pt = ppg + ppe;

            PF.Text = pt.ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            PartidosG.Text = "";
            PartidosE.Text = "";
            PartidosP.Text = "";
            PF.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
