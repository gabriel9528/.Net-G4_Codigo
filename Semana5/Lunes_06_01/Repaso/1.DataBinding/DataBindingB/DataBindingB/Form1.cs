namespace DataBindingB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Universidad universidad1 = new Universidad("UPC", "Universidad Peruana de Ciencias Aplicadas", "Av. Salaverry 2255, San Isidro");
            Universidad universidad2 = new Universidad("UNI", "Universidad Nacional de Ingeniería", "Av. Túpac Amaru 210, Rímac");
            Universidad universidad3 = new Universidad("PUCP", "Pontificia Universidad Católica del Perú", "Av. Universitaria 1801, San Miguel");
            Universidad universidad4 = new Universidad("USMP", "Universidad de San Martín de Porres", "Av. La Fontana 1250, La Molina");

            List<Universidad> universidades = new List<Universidad>();
            universidades.Add(universidad1);
            universidades.Add(universidad2);
            universidades.Add(universidad3);
            universidades.Add(universidad4);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = universidades;

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Acronimo";

            textBox1.DataBindings.Add("Text", bindingSource, "Nombre");
            textBox2.DataBindings.Add("Text", bindingSource, "Direccion");


        }
    }
}
