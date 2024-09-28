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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void PF_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            RC.Text = "";
            RI.Text = "";
            RB.Text = "";
            PF.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double rc = Convert.ToDouble(RC.Text);
            double ri = Convert.ToDouble(RI.Text);
            double rb = Convert.ToDouble(RB.Text);

            double prc = rc * 4;
            double pri = ri * -1;

            double pf = prc + pri;

            PF.Text = pf.ToString();
        }
    }
}
