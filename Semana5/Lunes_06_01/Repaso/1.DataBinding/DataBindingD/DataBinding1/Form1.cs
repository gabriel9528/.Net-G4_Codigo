using System.Windows.Forms;

namespace DataBinding1
{
    public partial class Form1 : Form
    {
        public List<Customer> CustomersList;
        public Form1()
        {
            InitializeComponent();

            CustomersList = new List<Customer>
            {
                new Customer { Name = "John Doe", Age = 30 },
                new Customer { Name = "Jane Smith", Age = 25 }
            };

            // Configurar el DataGridView
            dataGridView1.DataSource = CustomersList;

            // Manejar el evento SelectionChanged del DataGridView
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Configurar los TextBox con bindings iniciales
            if (CustomersList.Count > 0)
            {
                textBox1.DataBindings.Add("Text", CustomersList[0], "Name");
                textBox2.DataBindings.Add("Text", CustomersList[0], "Age");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                //Cuando enlazas una colección de datos (como una lista de objetos) a un DataGridView,
                //cada fila en el DataGridView se asocia con un elemento de la colección de datos.
                //La propiedad DataBoundItem te permite obtener el objeto original de datos de una
                //fila específica.
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;
                //Antes de añadir nuevas vinculaciones de datos, es importante limpiar cualquier vinculación
                //existente para evitar conflictos y asegurar que los TextBox se actualicen correctamente
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox1.DataBindings.Add("Text", selectedCustomer, "Name");
                textBox2.DataBindings.Add("Text", selectedCustomer, "Age");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
