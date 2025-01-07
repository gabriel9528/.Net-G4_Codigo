using System.ComponentModel;

namespace NotifyPropertyChanged2
{
    public partial class Form1 : Form
    {
        private BindingList<Customer> CustomerList { get; set; }
        public Form1()
        {
            InitializeComponent();

            CustomerList = new BindingList<Customer>()
            {
                new Customer() { Name = "Gabriel Fernando", Age = 29 },
                new Customer() { Name = "Rosita Torres", Age = 30 },
            };

            //Configurar el dataGridView
            dataGridView1.DataSource = CustomerList;

            //Manejar la seleccion multiple en el dataGridView
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
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
