using System.ComponentModel;
using System.Windows.Forms;

namespace NotifyChanged
{
    public partial class Form1 : Form
    {
        public BindingList<Customer> CustomersList { get; set; }

        public Form1()
        {
            InitializeComponent();

            CustomersList = new BindingList<Customer>
            {
                new Customer { Name = "Gabriel Retamozo", Age = 30 },
                new Customer { Name = "Jorge Rodriguez", Age = 25 }
            };

            // Configurar el DataGridView
            dataGridView1.DataSource = CustomersList;

            // Manejar el evento SelectionChanged del DataGridView
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Configurar los TextBox con bindings iniciales
            if (CustomersList.Count > 0)
            {
                textBoxName.DataBindings.Add("Text", CustomersList, "Name");
                textBoxAge.DataBindings.Add("Text", CustomersList, "Age");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;
                textBoxName.DataBindings.Clear();
                textBoxAge.DataBindings.Clear();
                textBoxName.DataBindings.Add("Text", selectedCustomer, "Name");
                textBoxAge.DataBindings.Add("Text", selectedCustomer, "Age");
            }
        }
    }
}
