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
    public partial class Pantalla3 : Form
    {
        private List<Persona> personaList;
        public Pantalla3()
        {
            InitializeComponent();
        }

        public List<Persona> PersonaList
        {
            get { return personaList; }
            set { personaList = value; }
        }

        private void Pantalla3_Load(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            foreach (Persona persona in personaList)
            {
                dataGridView1.Rows[n].Cells[0].Value = persona.Nombre;
                dataGridView1.Rows[n].Cells[1].Value = persona.Apellido;
                dataGridView1.Rows[n].Cells[2].Value = persona.Edad;
                dataGridView1.Rows[n].Cells[3].Value = persona.Direccion;
                dataGridView1.Rows[n].Cells[4].Value = persona.Genero;

                n++;
            }

        }

        private void button_P3_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
