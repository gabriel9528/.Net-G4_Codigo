using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntornoGrafico
{
    public partial class Pantalla2 : Form
    {
        private Persona persona;
        public Pantalla2()
        {
            InitializeComponent();
            persona = new Persona();
        }

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {
            label_P2_Nombres.Text = persona.Nombre;
            label_P2_Apellidos.Text = persona.Apellido;
            label_P2_Edad.Text = Convert.ToString(persona.Edad);
            label_P2_Direccion.Text = persona.Direccion;
            label_P2_Genero.Text = persona.Genero;
        }

        private void button_P2_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
