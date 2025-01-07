namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        private Producto _producto;

        public Form1()
        {
            InitializeComponent();

            // Inicializar el objeto Producto
            _producto = new Producto
            {
                Nombre = "Laptop",
                Precio = 1500.00m
            };

            // Configurar DataBindings
            textBoxNombre.DataBindings.Add("Text", _producto, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPrecio.DataBindings.Add("Text", _producto, "Precio", true, DataSourceUpdateMode.OnPropertyChanged);

            // Combinar Nombre y Precio en un solo Label
            labelMostrarPrecio.DataBindings.Add("Text", _producto, "DescripcionCompleta", true, DataSourceUpdateMode.OnPropertyChanged);

            // Configurar eventos adicionales (opcional)
            _producto.PropertyChanged += Producto_PropertyChanged;
        }

        private void Producto_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == "DescripcionCompleta")
            //{
            //    MessageBox.Show($"La descripción del producto ha cambiado: {_producto.DescripcionCompleta}");
            //}
        }
    }
}
