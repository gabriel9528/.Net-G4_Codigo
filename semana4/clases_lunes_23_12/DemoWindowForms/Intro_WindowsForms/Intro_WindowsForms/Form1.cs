namespace Intro_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bienvenido: {textBox_Nombres.Text}, {textBox_Apellidos} de edad: {textBox_Edad.Text}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void newWindow_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Nombres.Text = "Gabriel ";
        }
    }
}
