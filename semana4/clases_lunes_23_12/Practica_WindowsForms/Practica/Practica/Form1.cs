namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_changed_Click(object sender, EventArgs e)
        {
            if (radioButton_Soltero.Checked)
            {
                label_estadoCivil.Text = "Soltero";

            }
            else if (radioButton_Casado.Checked)
            {
                label_estadoCivil.Text = "Casado";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton_Soltero.Checked)
            {
                label_estadoCivil.Text = "Soltero";

            }
            else if (radioButton_Casado.Checked)
            {
                label_estadoCivil.Text = "Casado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_solero_2.Checked)
            {
                label_estadoCivil_2.Text = "Soltero";

            }
            else if (radioButton_casado_2.Checked)
            {
                label_estadoCivil_2.Text = "Casado";
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            string listView = textBox_listView.Text;
            listView_Datos.Items.Add(listView);
        }

        private void button_comprobarFecha_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;

            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                label_vacio.Text = "Es un fin de semana";
                label_vacio.BackColor = Color.Red;
            }
            else
            {
                label_vacio.Text = "Es un dia normal de trabajo";
                label_vacio.BackColor = Color.Green;
            }

        }
    }
}
