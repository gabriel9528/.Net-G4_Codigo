namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.DataBindings.Add("Text", textBox1, "Text");

            panel1.DataBindings.Add("BackColor", textBox1, "Text", true );

        }
    }
}
