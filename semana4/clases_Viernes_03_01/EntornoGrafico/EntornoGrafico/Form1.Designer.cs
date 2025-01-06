namespace EntornoGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxNombres = new TextBox();
            textBoxApellidos = new TextBox();
            label2 = new Label();
            textBoxEdad = new TextBox();
            label3 = new Label();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxGenero = new ComboBox();
            buttonPantallaDos = new Button();
            buttonPantallaTres = new Button();
            buttonInsertar = new Button();
            buttonSalir = new Button();
            buttonLimpiar = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(43, 80);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Location = new Point(165, 80);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(189, 23);
            textBoxNombres.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(165, 133);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(189, 23);
            textBoxApellidos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(43, 133);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(165, 186);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(189, 23);
            textBoxEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(43, 186);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(165, 244);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(189, 23);
            textBoxDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(43, 244);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(43, 305);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 8;
            label5.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxGenero.Location = new Point(165, 305);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(189, 23);
            comboBoxGenero.TabIndex = 9;
            // 
            // buttonPantallaDos
            // 
            buttonPantallaDos.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            buttonPantallaDos.FlatAppearance.BorderSize = 3;
            buttonPantallaDos.FlatAppearance.MouseDownBackColor = Color.Teal;
            buttonPantallaDos.FlatAppearance.MouseOverBackColor = Color.Teal;
            buttonPantallaDos.FlatStyle = FlatStyle.Flat;
            buttonPantallaDos.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPantallaDos.ForeColor = Color.Navy;
            buttonPantallaDos.Location = new Point(402, 109);
            buttonPantallaDos.Name = "buttonPantallaDos";
            buttonPantallaDos.Size = new Size(151, 49);
            buttonPantallaDos.TabIndex = 10;
            buttonPantallaDos.Text = "Pantalla Dos";
            buttonPantallaDos.UseVisualStyleBackColor = true;
            buttonPantallaDos.Click += buttonPantallaDos_Click;
            // 
            // buttonPantallaTres
            // 
            buttonPantallaTres.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            buttonPantallaTres.FlatAppearance.BorderSize = 3;
            buttonPantallaTres.FlatAppearance.MouseDownBackColor = Color.Teal;
            buttonPantallaTres.FlatAppearance.MouseOverBackColor = Color.Teal;
            buttonPantallaTres.FlatStyle = FlatStyle.Flat;
            buttonPantallaTres.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPantallaTres.ForeColor = Color.Navy;
            buttonPantallaTres.Location = new Point(402, 245);
            buttonPantallaTres.Name = "buttonPantallaTres";
            buttonPantallaTres.Size = new Size(151, 49);
            buttonPantallaTres.TabIndex = 11;
            buttonPantallaTres.Text = "Pantalla Tres";
            buttonPantallaTres.UseVisualStyleBackColor = true;
            buttonPantallaTres.Click += buttonPantallaTres_Click;
            // 
            // buttonInsertar
            // 
            buttonInsertar.BackColor = Color.Blue;
            buttonInsertar.FlatAppearance.BorderColor = Color.White;
            buttonInsertar.FlatAppearance.BorderSize = 3;
            buttonInsertar.FlatAppearance.MouseDownBackColor = Color.Teal;
            buttonInsertar.FlatAppearance.MouseOverBackColor = Color.Teal;
            buttonInsertar.FlatStyle = FlatStyle.Flat;
            buttonInsertar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInsertar.ForeColor = Color.White;
            buttonInsertar.Location = new Point(43, 361);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(151, 49);
            buttonInsertar.TabIndex = 12;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = false;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Blue;
            buttonSalir.FlatAppearance.BorderColor = Color.White;
            buttonSalir.FlatAppearance.BorderSize = 3;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Teal;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.Teal;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = Color.White;
            buttonSalir.Location = new Point(402, 361);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(151, 49);
            buttonSalir.TabIndex = 13;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Blue;
            buttonLimpiar.FlatAppearance.BorderColor = Color.White;
            buttonLimpiar.FlatAppearance.BorderSize = 3;
            buttonLimpiar.FlatAppearance.MouseDownBackColor = Color.Teal;
            buttonLimpiar.FlatAppearance.MouseOverBackColor = Color.Teal;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.ForeColor = Color.White;
            buttonLimpiar.Location = new Point(223, 361);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(151, 49);
            buttonLimpiar.TabIndex = 14;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(595, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(246, 9);
            label6.Name = "label6";
            label6.Size = new Size(327, 42);
            label6.TabIndex = 16;
            label6.Text = "Bienvenido al Sistema";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonPantallaTres);
            Controls.Add(buttonPantallaDos);
            Controls.Add(comboBoxGenero);
            Controls.Add(label5);
            Controls.Add(textBoxDireccion);
            Controls.Add(label4);
            Controls.Add(textBoxEdad);
            Controls.Add(label3);
            Controls.Add(textBoxApellidos);
            Controls.Add(label2);
            Controls.Add(textBoxNombres);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombres;
        private TextBox textBoxApellidos;
        private Label label2;
        private TextBox textBoxEdad;
        private Label label3;
        private TextBox textBoxDireccion;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxGenero;
        private Button buttonPantallaDos;
        private Button buttonPantallaTres;
        private Button buttonInsertar;
        private Button buttonSalir;
        private Button buttonLimpiar;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
