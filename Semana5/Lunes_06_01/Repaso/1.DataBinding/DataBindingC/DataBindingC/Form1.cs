namespace DataBindingC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Departamento> listaDepartamentos = new List<Departamento>();


            Departamento departamento = new Departamento("Ingenieria");
            departamento.Add(new Estudiante("Juan Ortiz", "Calle aLvarez THomas 500"));
            departamento.Add(new Estudiante("Pedro Gallese", "Calle Miguel Grau 202"));
            listaDepartamentos.Add(departamento);

            Departamento departamento2 = new Departamento("Ciencias");
            departamento2.Add(new Estudiante("Maria Perez", "Avenida Circunvalacion s/n"));
            departamento2.Add(new Estudiante("Ana Ramos", "Urbanizacion MZ B-8"));
            departamento2.Add(new Estudiante("Carlos Gomez", "Calle 2 de Mayo 100"));
            listaDepartamentos.Add(departamento2);


            BindingSource cboBindingSource = new BindingSource();
            BindingSource lboBindingSource = new BindingSource();

            cboBindingSource.DataSource = listaDepartamentos;

            lboBindingSource.DataSource = cboBindingSource;
            //DataMember:Es una propiedad del BindingSource que especifica qué miembro(una
            //propiedad o colección) del origen de datos debe ser usado para la vinculación.
            //Aquí, se indica que el miembro de cada objeto en listaDepartamentos que debe usarse
            //para la vinculación es la propiedad Estudiantessss.
            lboBindingSource.DataMember = "Estudiantessss1";

            comboBox1.DataSource = cboBindingSource;
            comboBox1.DisplayMember = "NombreDepartamento";

            listBox1.DataSource = lboBindingSource;
            listBox1.DisplayMember = "NombreEstudiante";

            textBox1.DataBindings.Add("Text", lboBindingSource, "Direccion");

        }
    }
}
