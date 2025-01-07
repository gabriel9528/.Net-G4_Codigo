namespace BindingSource2
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource;
        private DataGridView dataGridView1;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private Button buttonName;
        private Button buttonAge;
        private Button buttonSave;

        public Form1()
        {
            InitializeComponent();

            // Inicializar controles
            InitializeControls();

            // Inicializar BindingSource y cargar datos
            InitializeBindingSource();
        }

        private void InitializeControls()
        {
            // Configurar columnas del DataGridView
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";

            DataGridViewTextBoxColumn colAge = new DataGridViewTextBoxColumn();
            colAge.DataPropertyName = "Age";
            colAge.HeaderText = "Age";

            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colAge);

        }

        private void InitializeBindingSource()
        {
            List<Customer> customersList = new List<Customer>
            {
                new Customer { Name = "Pilar Doe", Age = 30 },
                new Customer { Name = "Jane Smith", Age = 50 },
                new Customer { Name = "Mike Johnson", Age = 15 }
            };

            bindingSource = new BindingSource();
            bindingSource.DataSource = customersList;

            dataGridView1.DataSource = bindingSource;
        }


        private void buttonName_Click(object sender, EventArgs e)
        {
            bindingSource.Sort = "Name ASC";

            // Crear una lista ordenada por edad
            List<Customer> sortedCustomersName = bindingSource.DataSource as List<Customer>;
            var sortedListName = sortedCustomersName.OrderBy(c => c.Name).ToList();

            // Limpiar y actualizar el ListView
            listView1.Items.Clear();
            foreach (var customer in sortedListName)
            {
                listView1.Items.Add(new ListViewItem(new[] { customer.Name, customer.Age.ToString() }));
            }
        }

        private void buttonAge_Click(object sender, EventArgs e)
        {
            bindingSource.Sort = "Age ASC";

            // Crear una lista ordenada por edad
            List<Customer> sortedCustomersAge = bindingSource.DataSource as List<Customer>;
            var sortedListAge = sortedCustomersAge.OrderBy(c => c.Age).ToList();

            // Limpiar y actualizar el ListView
            listView2.Items.Clear();
            foreach (var customer in sortedListAge)
            {
                listView2.Items.Add(new ListViewItem(new[] { customer.Name, customer.Age.ToString() }));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar cambios
                List<Customer> updatedCustomers = bindingSource.DataSource as List<Customer>;
                //Este método asegura que cualquier edición pendiente en el BindingSource
                //(o en sus controles enlazados, como el DataGridView) se finalize.
                //Esto es útil, por ejemplo, si un usuario ha editado una celda en el
                //DataGridView pero no ha movido el foco fuera de la celda.
                bindingSource.EndEdit();
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;
                if (selectedCustomer != null)
                {
                    textBoxName.Text = selectedCustomer.Name;
                    textBoxAge.Text = selectedCustomer.Age.ToString();
                }
            }
        }
    }

}
