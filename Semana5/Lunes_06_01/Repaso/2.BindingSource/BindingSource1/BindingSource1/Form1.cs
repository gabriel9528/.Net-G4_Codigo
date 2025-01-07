namespace BindingSource1
{
    public partial class Form1 : Form
    {
        private BindingSource customerBindingSource;
        private BindingSource comboBoxBindingSource;

        public Form1()
        {
            InitializeComponent();

            // Inicializar lista de clientes
            List<Customer> customersList = new List<Customer>
            {
                new Customer { Name = "Gabriel Retamozo", Age = 30 },
                new Customer { Name = "Andrea Torres", Age = 25 },
                new Customer { Name = "Mike Flores", Age = 35 }
            };

            // Inicializar BindingSource
            customerBindingSource = new BindingSource();
            comboBoxBindingSource = new BindingSource();

            // Configurar BindingSource con la lista de clientes
            customerBindingSource.DataSource = customersList;
            comboBoxBindingSource.DataSource = customersList;

            // Configurar DataGridView
            dataGridView1.DataSource = customerBindingSource;

            // Configurar ComboBox
            comboBox1.DataSource = comboBoxBindingSource;
            comboBox1.DisplayMember = "Name";

            // Configurar TextBox
            textBox1.DataBindings.Add("Text", customerBindingSource, "Name");
            textBox2.DataBindings.Add("Text", customerBindingSource, "Age");

            // Manejar el evento SelectionChanged del DataGridView
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox1.DataBindings.Add("Text", selectedCustomer, "Name");
                textBox2.DataBindings.Add("Text", selectedCustomer, "Age");
            }
        }
    }
}
