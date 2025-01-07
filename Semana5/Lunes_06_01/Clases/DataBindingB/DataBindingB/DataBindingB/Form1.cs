namespace DataBindingB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Universidad universidad1 = new Universidad("UPC", "Universidad Peruana de ciencias Aplicadas", "Av. Salaverry 300");
            Universidad universidad2 = new Universidad("UNI", "Universidad Nacional de Ingenieria", "Av. Tupac Amaru 500");
            Universidad universidad3 = new Universidad("PUCP", "Universidad Catolica del Peru", "Av. Independencia s/n");
            Universidad universidad4 = new Universidad("USMP", "Universidad San Martin de Porres", "Av. Las Palmeras 800");

            List<Universidad> universidades = [];
            universidades.Add(universidad1);
            universidades.Add (universidad2);
            universidades.Add((universidad3));
            universidades.Add ((universidad4));

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = universidades;

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Acronimo";

            textBox1.DataBindings.Add("Text", bindingSource, "Nombre");
            textBox2.DataBindings.Add("Text", bindingSource, "Direccion");

        }
    }
}
