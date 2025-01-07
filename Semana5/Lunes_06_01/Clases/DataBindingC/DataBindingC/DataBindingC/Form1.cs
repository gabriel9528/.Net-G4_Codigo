using System.Windows.Forms;

namespace DataBindingC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Departamento> listaDepartamentos = new List<Departamento>();

            Departamento departamentoIngenierias = new Departamento("Ingenierias");
            departamentoIngenierias.Add(new Estudiante("Gabriel Fernando", "Calle Soa Ruiz s/n"));
            departamentoIngenierias.Add(new Estudiante("Pepito Torres", "calle Santo Thomas"));
            listaDepartamentos.Add(departamentoIngenierias);


            Departamento departamentoCiencias = new Departamento("Ciencias");
            departamentoCiencias.Add(new Estudiante("Andrea Rosales", "calle 1"));
            departamentoCiencias.Add(new Estudiante("Rosa Martinez", "calle 2"));
            departamentoCiencias.Add(new Estudiante("Juana Lucrecia", "calle 3"));
            listaDepartamentos.Add(departamentoCiencias);


            BindingSource cboBindingSource = new BindingSource();
            BindingSource lboBindingSource = new BindingSource();

            cboBindingSource.DataSource = listaDepartamentos;
            lboBindingSource.DataSource = cboBindingSource;

            lboBindingSource.DataMember = "ListStudent";

            comboBox1.DataSource = cboBindingSource;
            comboBox1.DisplayMember = "NombreDepartamento";

            listBox1.DataSource = lboBindingSource;
            listBox1.DisplayMember = "NombreEstudiante";


            textBox1.DataBindings.Add("Text", lboBindingSource, "Direccion");


        }
    }
}
