namespace EntornoGrafico
{
    public partial class Form1 : Form
    {
        private ControladorPersona controladorPersona;
        private Persona persona;
        private List<Persona> personaList;
        public Form1()
        {
            InitializeComponent();
            controladorPersona = new ControladorPersona();
            persona = new Persona();
            personaList = new List<Persona>();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Persona newPersona = new Persona();
            newPersona.Nombre = textBoxNombres.Text;
            newPersona.Apellido = textBoxApellidos.Text;
            newPersona.Edad = Convert.ToInt32(textBoxEdad.Text);
            newPersona.Direccion = textBoxDireccion.Text;
            newPersona.Genero = Convert.ToString(comboBoxGenero.Items[comboBoxGenero.SelectedIndex]);

            persona = newPersona;
            controladorPersona.AgregarPersona(persona);
            personaList = controladorPersona.ObtenerPersonas();

            MessageBox.Show("Bienvenido/a al sistema "
                + newPersona.Nombre
                + " "
                + newPersona.Apellido
                + " de "
                + newPersona.Edad
                + " años de edad.");

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxEdad.Text = "";
            textBoxDireccion.Text = "";
            comboBoxGenero.SelectedIndex = 0;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPantallaDos_Click(object sender, EventArgs e)
        {
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Persona = persona;
            pantalla2.ShowDialog();
        }

        private void buttonPantallaTres_Click(object sender, EventArgs e)
        {
            Pantalla3 pantalla3 = new Pantalla3();
            pantalla3.PersonaList = personaList;
            pantalla3.ShowDialog();
        }

    }
}
