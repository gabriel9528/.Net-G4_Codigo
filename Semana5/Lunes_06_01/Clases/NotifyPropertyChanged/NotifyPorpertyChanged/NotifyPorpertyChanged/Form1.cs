namespace NotifyPorpertyChanged
{
    public partial class Form1 : Form
    {
        private Producto _producto;
        public Form1()
        {
            InitializeComponent();

            //Inicializar el objeto producto
            _producto = new Producto()
            {
                Nombre = "Laptop",
                Precio = 2000.00m
            };

            //Configurar DataBindings
            textBoxNombre.DataBindings.Add("Text", _producto, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPrecio.DataBindings.Add("Text", _producto, "Precio", true, DataSourceUpdateMode.OnPropertyChanged);

            //Configurar el label -> nombre y precio
            labelDescripcion.DataBindings.Add("Text", _producto, "DescripcionCompleta", true, DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
