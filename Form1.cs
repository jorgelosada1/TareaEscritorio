namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Operador1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operador2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double operador1 = Convert.ToDouble(Operador1.Text);
                double operador2 = Convert.ToDouble(Operador2.Text);


                double resultado = operador1 * operador2;


                Resultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Operador1.Text = "";
            Operador2.Text = "";
            Resultado.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
   
            this.Close();
        }
    }
}
