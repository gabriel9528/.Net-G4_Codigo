namespace EntornoGrafico
{
    partial class Pantalla3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            button_P3_Salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellidos, Edad, Direccion, Genero });
            dataGridView1.Location = new Point(43, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 281);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // button_P3_Salir
            // 
            button_P3_Salir.BackColor = Color.SpringGreen;
            button_P3_Salir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_P3_Salir.ForeColor = Color.Teal;
            button_P3_Salir.Location = new Point(631, 377);
            button_P3_Salir.Name = "button_P3_Salir";
            button_P3_Salir.Size = new Size(136, 43);
            button_P3_Salir.TabIndex = 11;
            button_P3_Salir.Text = "Salir";
            button_P3_Salir.UseVisualStyleBackColor = false;
            button_P3_Salir.Click += button_P3_Salir_Click;
            // 
            // Pantalla3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button_P3_Salir);
            Controls.Add(dataGridView1);
            Name = "Pantalla3";
            Text = "Pantalla3";
            Load += Pantalla3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Genero;
        private Button button_P3_Salir;
    }
}