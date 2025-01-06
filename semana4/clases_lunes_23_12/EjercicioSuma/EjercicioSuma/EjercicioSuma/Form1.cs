namespace EjercicioSuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {

            if (!Int32.TryParse(textBox_primerNumero.Text, out int number_one))
            {
                MessageBox.Show("Es obligatorio solo ingresar numeros");
            }

            if (!Int32.TryParse(textBox_SegundoNumero.Text, out int number_two))
            {
                MessageBox.Show("Es obligatorio solo ingresar numeros");
            }

            int result = number_one + number_two;

            label_Resultado.Text = result.ToString();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_primerNumero.Text = "";
            textBox_SegundoNumero.Text = "";
            label_Resultado.Text = "";
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
