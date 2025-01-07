namespace BindingSource1
{
    public partial class Form1 : Form
    {
        private BindingSource customerBindingSource;
        private BindingSource comboBoxBindingSource;
        public Form1()
        {
            InitializeComponent();

            //Inicializar los clientes
            List<Customer> customerList = new List<Customer>()
            {
                new Customer() { Name = "Gabriel Fernando", Age = 29 },
                new Customer() { Name = "Andrea Taffur", Age = 35 },
                new Customer() { Name = "Ricardo Alexander", Age = 40 },
            };

            //Inicializar los binding Sources
            customerBindingSource = new BindingSource();
            comboBoxBindingSource = new BindingSource();

            //Configurar bindingSource con la lista de clientes
            customerBindingSource.DataSource = customerList;
            comboBoxBindingSource.DataSource = customerList;

            //Enlazar
            comboBox1.DataSource = comboBoxBindingSource;
            comboBox1.DisplayMember = "Name";

            dataGridView1.DataSource = customerBindingSource;

            //Configurar los textBoxs
            textBox1.DataBindings.Add("Text", customerBindingSource, "Name");
            textBox2.DataBindings.Add("Text", customerBindingSource, "Age");

            //Manejar la seleccion multiple para mi dataGridView
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox1.DataBindings.Add("Text",  selectedCustomer, "Name");
                textBox2.DataBindings.Add("Text",  selectedCustomer, "Age");
            }
        }
    }
}
