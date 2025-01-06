using System.Collections;

namespace AplicacionVentas
{
    public partial class Form1 : Form
    {
        //Inicializar areglo de productos
        static string[] productos = { "Celular", "Laptop", "Monitor", "Televisor", "Lavadora" };

        //ArrayList de objetos
        ArrayList listProducts = new ArrayList(productos);

        //Instancia de nuestra clase ventas
        Ventas ventas = new Ventas();

        double total;
        public Form1()
        {
            InitializeComponent();
            MostrarFecha();
            MostrarHora();
            LimpiarCampos();
            LlenarProductos();
        }

        private void MostrarFecha()
        {
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void LimpiarCampos()
        {
            textBoxCliente.Clear();
            comboBoxProducto.Text = "Seleccione un producto";
            textBoxCantidad.Clear();
            labelPrecio.Text = "0.00";
            textBoxCliente.Focus();

        }

        private void LlenarProductos()
        {
            foreach (var item in listProducts)
            {
                comboBoxProducto.Items.Add(item);
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ventas.Producto = comboBoxProducto.Text;
            labelPrecio.Text = ventas.AsignarPrecio().ToString("C");
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //Enviar datos a la clase venta
            ventas.Producto = comboBoxProducto.Text;
            ventas.Cantidad = int.Parse(textBoxCantidad.Text);

            //Traer los resultados en mi listView
            ListViewItem fila = new ListViewItem(ventas.Producto);
            fila.SubItems.Add(ventas.Cantidad.ToString());
            fila.SubItems.Add(ventas.AsignarPrecio().ToString("C"));
            fila.SubItems.Add(ventas.CalcularSubTotal().ToString("C"));
            fila.SubItems.Add(ventas.CalcularDescuento().ToString("C"));
            fila.SubItems.Add(ventas.CalcularNeto().ToString("C"));

            listView1.Items.Add(fila);

            total += ventas.CalcularNeto();

            //Imprimir el total
            labelTotal.Text = total.ToString("C");

            LimpiarCampos();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicacion?",
                "Ventas",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }
    }
}
