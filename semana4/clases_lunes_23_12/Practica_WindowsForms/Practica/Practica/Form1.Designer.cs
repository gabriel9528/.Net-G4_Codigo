namespace Practica
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
            checkBox_Hombre = new CheckBox();
            checkBox_Mujer = new CheckBox();
            label_genero = new Label();
            radioButton_Soltero = new RadioButton();
            radioButton_Casado = new RadioButton();
            label_estadoCivil = new Label();
            button_changed = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label_estadoCivil_2 = new Label();
            radioButton_casado_2 = new RadioButton();
            radioButton_solero_2 = new RadioButton();
            pictureBox1 = new PictureBox();
            listView_Datos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button_Agregar = new Button();
            textBox_listView = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button_comprobarFecha = new Button();
            label_vacio = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox_Hombre
            // 
            checkBox_Hombre.AutoSize = true;
            checkBox_Hombre.Location = new Point(42, 29);
            checkBox_Hombre.Name = "checkBox_Hombre";
            checkBox_Hombre.Size = new Size(70, 19);
            checkBox_Hombre.TabIndex = 0;
            checkBox_Hombre.Text = "Hombre";
            checkBox_Hombre.UseVisualStyleBackColor = true;
            // 
            // checkBox_Mujer
            // 
            checkBox_Mujer.AutoSize = true;
            checkBox_Mujer.Location = new Point(39, 65);
            checkBox_Mujer.Name = "checkBox_Mujer";
            checkBox_Mujer.Size = new Size(57, 19);
            checkBox_Mujer.TabIndex = 1;
            checkBox_Mujer.Text = "Mujer";
            checkBox_Mujer.UseVisualStyleBackColor = true;
            // 
            // label_genero
            // 
            label_genero.AutoSize = true;
            label_genero.Location = new Point(39, 108);
            label_genero.Name = "label_genero";
            label_genero.Size = new Size(45, 15);
            label_genero.TabIndex = 2;
            label_genero.Text = "Genero";
            // 
            // radioButton_Soltero
            // 
            radioButton_Soltero.AutoSize = true;
            radioButton_Soltero.Location = new Point(198, 32);
            radioButton_Soltero.Name = "radioButton_Soltero";
            radioButton_Soltero.Size = new Size(62, 19);
            radioButton_Soltero.TabIndex = 3;
            radioButton_Soltero.TabStop = true;
            radioButton_Soltero.Text = "Soltero";
            radioButton_Soltero.UseVisualStyleBackColor = true;
            // 
            // radioButton_Casado
            // 
            radioButton_Casado.AutoSize = true;
            radioButton_Casado.Location = new Point(198, 64);
            radioButton_Casado.Name = "radioButton_Casado";
            radioButton_Casado.Size = new Size(64, 19);
            radioButton_Casado.TabIndex = 4;
            radioButton_Casado.TabStop = true;
            radioButton_Casado.Text = "Casado";
            radioButton_Casado.UseVisualStyleBackColor = true;
            // 
            // label_estadoCivil
            // 
            label_estadoCivil.AutoSize = true;
            label_estadoCivil.Location = new Point(198, 108);
            label_estadoCivil.Name = "label_estadoCivil";
            label_estadoCivil.Size = new Size(66, 15);
            label_estadoCivil.TabIndex = 5;
            label_estadoCivil.Text = "Estado civil";
            // 
            // button_changed
            // 
            button_changed.Location = new Point(198, 3);
            button_changed.Name = "button_changed";
            button_changed.Size = new Size(75, 23);
            button_changed.TabIndex = 6;
            button_changed.Text = "Changed";
            button_changed.UseVisualStyleBackColor = true;
            button_changed.Click += button_changed_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label_estadoCivil_2);
            groupBox1.Controls.Add(radioButton_casado_2);
            groupBox1.Controls.Add(radioButton_solero_2);
            groupBox1.Location = new Point(336, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 139);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(153, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Changed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_estadoCivil_2
            // 
            label_estadoCivil_2.AutoSize = true;
            label_estadoCivil_2.Location = new Point(81, 107);
            label_estadoCivil_2.Name = "label_estadoCivil_2";
            label_estadoCivil_2.Size = new Size(66, 15);
            label_estadoCivil_2.TabIndex = 9;
            label_estadoCivil_2.Text = "Estado civil";
            // 
            // radioButton_casado_2
            // 
            radioButton_casado_2.AutoSize = true;
            radioButton_casado_2.Location = new Point(83, 60);
            radioButton_casado_2.Name = "radioButton_casado_2";
            radioButton_casado_2.Size = new Size(64, 19);
            radioButton_casado_2.TabIndex = 8;
            radioButton_casado_2.TabStop = true;
            radioButton_casado_2.Text = "Casado";
            radioButton_casado_2.UseVisualStyleBackColor = true;
            // 
            // radioButton_solero_2
            // 
            radioButton_solero_2.AutoSize = true;
            radioButton_solero_2.Location = new Point(85, 35);
            radioButton_solero_2.Name = "radioButton_solero_2";
            radioButton_solero_2.Size = new Size(62, 19);
            radioButton_solero_2.TabIndex = 7;
            radioButton_solero_2.TabStop = true;
            radioButton_solero_2.Text = "Soltero";
            radioButton_solero_2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // listView_Datos
            // 
            listView_Datos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_Datos.Location = new Point(274, 206);
            listView_Datos.Name = "listView_Datos";
            listView_Datos.Size = new Size(142, 122);
            listView_Datos.TabIndex = 9;
            listView_Datos.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Lima";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cusco";
            // 
            // button_Agregar
            // 
            button_Agregar.Location = new Point(297, 351);
            button_Agregar.Name = "button_Agregar";
            button_Agregar.Size = new Size(75, 23);
            button_Agregar.TabIndex = 10;
            button_Agregar.Text = "Agregar";
            button_Agregar.UseVisualStyleBackColor = true;
            button_Agregar.Click += button_Agregar_Click;
            // 
            // textBox_listView
            // 
            textBox_listView.Location = new Point(285, 380);
            textBox_listView.Name = "textBox_listView";
            textBox_listView.Size = new Size(100, 23);
            textBox_listView.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(447, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // button_comprobarFecha
            // 
            button_comprobarFecha.Location = new Point(648, 252);
            button_comprobarFecha.Name = "button_comprobarFecha";
            button_comprobarFecha.Size = new Size(89, 23);
            button_comprobarFecha.TabIndex = 13;
            button_comprobarFecha.Text = "Comprobar";
            button_comprobarFecha.UseVisualStyleBackColor = true;
            button_comprobarFecha.Click += button_comprobarFecha_Click;
            // 
            // label_vacio
            // 
            label_vacio.AutoSize = true;
            label_vacio.BackColor = SystemColors.ControlLight;
            label_vacio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_vacio.Location = new Point(447, 250);
            label_vacio.Name = "label_vacio";
            label_vacio.Size = new Size(58, 25);
            label_vacio.TabIndex = 14;
            label_vacio.Text = "Vacio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_vacio);
            Controls.Add(button_comprobarFecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_listView);
            Controls.Add(button_Agregar);
            Controls.Add(listView_Datos);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button_changed);
            Controls.Add(label_estadoCivil);
            Controls.Add(radioButton_Casado);
            Controls.Add(radioButton_Soltero);
            Controls.Add(label_genero);
            Controls.Add(checkBox_Mujer);
            Controls.Add(checkBox_Hombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_Hombre;
        private CheckBox checkBox_Mujer;
        private Label label_genero;
        private RadioButton radioButton_Soltero;
        private RadioButton radioButton_Casado;
        private Label label_estadoCivil;
        private Button button_changed;
        private GroupBox groupBox1;
        private Label label_estadoCivil_2;
        private RadioButton radioButton_casado_2;
        private RadioButton radioButton_solero_2;
        private Button button1;
        private PictureBox pictureBox1;
        private ListView listView_Datos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button_Agregar;
        private TextBox textBox_listView;
        private DateTimePicker dateTimePicker1;
        private Button button_comprobarFecha;
        private Label label_vacio;
    }
}
